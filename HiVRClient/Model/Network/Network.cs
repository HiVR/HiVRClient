// <copyright file="Network.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.Network
{
    using SerializedObjects;
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Contains all the logic for the network layer.
    /// </summary>
    public class Network
    {
        #region Fields

        /// <summary>
        /// The boolean flag that determines whether the connection process is going on.
        /// </summary>
        private bool keepConnecting;

        /// <summary>
        /// Event class to notify thread about activity.
        /// </summary>
        private ManualResetEvent allDone = new ManualResetEvent(false);

        /// <summary>
        /// Is called when an object is received.
        /// </summary>
        public event EventHandler<ObjectReceivedEventArgs> ObjectReceived;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Open the connection with the environment.
        /// </summary>
        /// <param name="ip">the ip to connect to</param>
        /// <param name="port">the port to connect to</param>
        public void OpenConnection(string ip, int port)
        {
            this.keepConnecting = true;
            Task.Run(() => this.Connect(ip, port));
        }

        /// <summary>
        /// Close the open connection.
        /// </summary>
        public void CloseConnection()
        {
            this.keepConnecting = false;
        }

        /// <summary>
        /// Event class to notify thread about activity.
        /// </summary>
        /// <param name="ip">IP used for making a connection</param>
        /// <param name="port">port used for making a connection</param>
        public void Connect(string ip, int port)
        {
            while (this.keepConnecting)
            {
                Console.Out.WriteLine("Client: Connecting...");

                // Reset the event notifier.
                this.allDone.Reset();

                // Setup receiving socket.
                Socket receiver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Parse IP address
                IPAddress validAddress = this.ParseIP(ip);

                // Initiate the connection, once connected call the callback function "Connect".
                receiver.BeginConnect(new IPEndPoint(validAddress, port), this.Connect, receiver);

                // Wait until packet is received.
                this.allDone.WaitOne();
            }
        }

        /// <summary>
        /// Method to transform a string ip or hostname to a valid IPAddress
        /// </summary>
        /// <param name="ip">string to transform</param>
        /// <returns>valid IPAddress</returns>
        public IPAddress ParseIP(string ip)
        {
            IPAddress res;
            if (!IPAddress.TryParse(ip, out res))
            {
                res = Dns.GetHostAddresses(ip)[1];
            }

            return res;
        }

        /// <summary>
        /// Starts when the connection was accepted by the remote hosts and prepares to receive data.
        /// </summary>
        /// <param name="result">contains the connection to the remote host</param>
        public void Connect(IAsyncResult result)
        {
            Console.Out.WriteLine("Client: Connected");

            // Initialize new SerializableTransformObject.
            SerializableTransformObject serializableTransform = new SerializableTransformObject();

            // Receive socket from result.
            serializableTransform.Socket = (Socket)result.AsyncState;

            try
            {
                // End "connect" phase.
                serializableTransform.Socket.EndConnect(result);

                // Start "receive" phase. Once data starts flowing in, call the callback function "Receive".
                serializableTransform.Socket.BeginReceive(serializableTransform.Buffer, 0, serializableTransform.Buffer.Length, SocketFlags.None, this.Receive, serializableTransform);
            }
            catch (SocketException e)
            {
                Console.Out.WriteLine("Client: Socket exception occured while connected. " + e.Message);

                Console.Out.WriteLine("Client: Trying to reconnect.");

                // Signal to start new connection.
                this.allDone.Set();
            }
        }

        /// <summary>
        /// Receives the data, puts it in a buffer and checks if we need to receive again.
        /// </summary>
        /// <param name="result">contains the connection to the remote host</param>
        public void Receive(IAsyncResult result)
        {
            try
            {
                // Retrieve SerializableTransformObject from result.
                SerializableTransformObject serializableTransform = (SerializableTransformObject)result.AsyncState;

                // Get amount of data received.
                int read = serializableTransform.Socket.EndReceive(result);

                // If it's more then zero, we actually received something!
                if (read > 0)
                {
                    // Collect all received data and put it in the TransmissionBuffer.
                    for (int i = 0; i < read; i++)
                    {
                        serializableTransform.TransmissionBuffer.Add(serializableTransform.Buffer[i]);
                    }

                    // If the amount read is equal to the buffer size, try to receive more data, because we don't know if their is.
                    if (read == serializableTransform.Buffer.Length)
                    {
                        // Start receiving again.
                        serializableTransform.Socket.BeginReceive(serializableTransform.Buffer, 0, serializableTransform.Buffer.Length, SocketFlags.None, this.Receive, serializableTransform);
                    }
                    else
                    {
                        // Done reading, process SerializableTransformObject.
                        this.Done(serializableTransform);
                    }
                }
                else
                {
                    // Done reading, process SerializableTransformObject.
                    this.Done(serializableTransform);
                }
            }
            catch (SocketException e)
            {
                Console.Out.WriteLine("Socket exception occured while receiving. " + e.Message);

                Console.Out.WriteLine("Trying to reconnect.");

                // Signal to start new connection.
                this.allDone.Set();
            }
        }

        /// <summary>
        /// De-serializes and outputs the received object.
        /// </summary>
        /// <param name="serializableTransform">contains an Unity object that been serialized</param>
        public void Done(SerializableTransformObject serializableTransform)
        {
            SerializableTransformObject received = serializableTransform.DeSerialize();
            Console.Out.WriteLine("Received transform-object with id: " + received.Id + " of type: " + received.Type);

            this.OnObjectReceived(new ObjectReceivedEventArgs(received));

            // Signal thread to continue, it will jump back to the first while loop and starts waiting for a connection again.
            this.allDone.Set();
        }

        /// <summary>
        /// Must be called to invoke the event.
        /// </summary>
        /// <param name="e">the event arguments</param>
        private void OnObjectReceived(ObjectReceivedEventArgs e)
        {
            this.ObjectReceived?.Invoke(this, e);
        }

        #endregion Methods
    }
}