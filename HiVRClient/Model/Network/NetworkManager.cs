// <copyright file="NetworkManager.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.Network
{
    using System;
    using System.Net.Sockets;

    /// <summary>
    /// This class is responsible for communicating with our Unity environment.
    /// </summary>
    internal class NetworkManager
    {
        #region Fields

        /// <summary>
        /// Contains the byte size used in the buffer for messages.
        /// </summary>
        private const int BYTESIZE = 1024 * 1024;

        /// <summary>
        /// Contains the active client object.
        /// </summary>
        private static TcpClient server;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a connection to the Unity Environment and send and receive a test message.
        /// </summary>
        /// <param name="ip">IP to connect to</param>
        /// <param name="port">port to connect to</param>
        public static void CreateConnection(string ip, int port)
        {
            try
            {
                byte[] writeBytes;
                byte[] readBytes = new byte[BYTESIZE];

                server = new TcpClient(ip, port); // Create a new connection.
                Console.WriteLine("Connected to Unity Server at " + server.Client.LocalEndPoint.ToString());

                NetworkStream stream = server.GetStream();

                // Send test message/command to Unity.
                writeBytes = System.Text.Encoding.Unicode.GetBytes("TEST");
                stream.Write(writeBytes, 0, writeBytes.Length);

                // Receive the first accept message from the environment.
                stream.Read(readBytes, 0, BYTESIZE);
                Console.WriteLine("[UNITY] " + CleanMessage(readBytes));
            }
            catch (SocketException e)
            {
                Console.WriteLine("[ERROR] SocketException!");
            }
        }

        /// <summary>
        /// This method is responsible for receiving a buffer and converting it to a ASCII message.
        /// </summary>
        /// <param name="bytes">buffer with the client message</param>
        /// <returns>string that contains ASCII message</returns>
        private static string CleanMessage(byte[] bytes)
        {
            string message = System.Text.Encoding.ASCII.GetString(bytes);

            string res = string.Empty;
            foreach (char nullChar in message)
            {
                if (nullChar != '\0')
                {
                    res += nullChar;
                }
            }

            return res;
        }

        #endregion Methods
    }
}