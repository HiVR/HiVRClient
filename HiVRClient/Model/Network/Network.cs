﻿// <copyright file="Network.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.Model.Network
{
    using Map;
    using SerializedObjects;
    using System.Net.Sockets;
    using System.Threading;
    using System;
    using System.Net;

    /// <summary>
    /// Contains all the logic for the network layer.
    /// </summary>
    public class Network
    {
        #region Fields

        /// <summary>
        /// Event class to notify thread about activity.
        /// </summary>
        ManualResetEvent allDone = new ManualResetEvent(false);

        #endregion Fields

        #region Methods

        /// <summary>
        /// Event class to notify thread about activity.
        /// </summary>
        public void Connect(string ip, int port)
        {
            while (true)
            {
                Console.Out.WriteLine("Client: Connecting...");
                
                // Reset the event notifier.
                allDone.Reset();

                // Setup receiving socket.
                Socket receiver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Initiate the connection, once connected call the callback function "Connect"
                receiver.BeginConnect(new IPEndPoint(IPAddress.Parse(ip), port), Connect, receiver);

                // Wait until packet is received.
                allDone.WaitOne();
            }
        }

        /// <summary>
        /// Starts when the connection was accepted by the remote hosts and prepares to receive data
        /// </summary>        
        public void Connect(IAsyncResult result)
        {
            Console.Out.WriteLine("Client: Connected");

            // Initialize new SerializableTransformObject.
            SerializableTransformObject serializableTransform = new SerializableTransformObject();

            // Receive socket from result.
            serializableTransform.Socket = (Socket)result.AsyncState;

            // End "connect" phase.
            serializableTransform.Socket.EndConnect(result);

            // Start "receive" phase. Once data starts flowing in, call the callback function "Receive"
            serializableTransform.Socket.BeginReceive(serializableTransform.buffer, 0, serializableTransform.buffer.Length, SocketFlags.None, Receive, serializableTransform);
        }


        /// <summary>
        /// Receives the data, puts it in a buffer and checks if we need to receive again.
        /// </summary>            
        public void Receive(IAsyncResult result)
        {
            // Retrieve SerializableTransformObject from result.
            SerializableTransformObject serializableTransform = (SerializableTransformObject)result.AsyncState;

            // Get amount of data received.
            int read = serializableTransform.Socket.EndReceive(result);

            // If it's more then zero, we actually received something!
            if (read > 0)
            {
                // Collect all received data and put it in the TransmissionBuffer
                for (int i = 0; i < read; i++)
                {
                    serializableTransform.TransmissionBuffer.Add(serializableTransform.buffer[i]);
                }

                // If the amount read is equal to the buffer size, try to receive more data, because we don't know if their is.
                if (read == serializableTransform.buffer.Length)
                {
                    // Start receiving again.
                    serializableTransform.Socket.BeginReceive(serializableTransform.buffer, 0, serializableTransform.buffer.Length, SocketFlags.None, Receive, serializableTransform);
                }
                else
                {
                    // Done reading, process SerializableTransformObject
                    Done(serializableTransform);
                }
            }
            else
            {
                // Done reading, process SerializableTransformObject
                Done(serializableTransform);
            }
        }

        /// <summary>
        /// Deserializes and outputs the received object
        /// </summary>            
        public void Done(SerializableTransformObject serializableTransform)
        {
            SerializableTransformObject received = serializableTransform.DeSerialize();
            Console.Out.WriteLine("Received transformobject with id: " + received.id);

            if (received.isStatic)
            {
                ObjectTracker.AddStaticObject(received);
            } else
            {
                ObjectTracker.AddDynamicObject(received);
            }

            // Signal thread to continue, it will jump back to the first while loop and starts waiting for a connection again.
            allDone.Set(); 
        }

        #endregion Methods
    }
}
