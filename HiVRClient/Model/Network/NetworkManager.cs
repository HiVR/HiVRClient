// <copyright file="NetworkManager.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.Network
{
    using System;
    using System.Net.Sockets;

    /// <summary>
    /// This class is responsible for communicating with our Unity environment
    /// </summary>
    internal class NetworkManager
    {
        #region Fields

        /// <summary>
        /// Contains the byte size used in the buffer for messages
        /// </summary>
        private const int BYTESIZE = 1024 * 1024;

        /// <summary>
        /// Contains the active client object
        /// </summary>
        private static TcpClient server;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a connection to the Unity Environment and send and receive a test message
        /// </summary>
        /// <param name="ip">IP to connect to</param>
        /// <param name="port">Port to connect to</param>
        public static void CreateConnection(string ip, int port)
        {
            server = new TcpClient(ip, port); // Create a new connection
            NetworkStream stream = server.GetStream();

            byte[] messageBytes = System.Text.Encoding.Unicode.GetBytes("TEST");
            stream.Write(messageBytes, 0, messageBytes.Length); // Write the bytes

            Console.WriteLine("Connected to Unity Server at " + server.Client.LocalEndPoint.ToString());

            messageBytes = new byte[BYTESIZE]; // Clear the message

            // Receive the stream of bytes
            stream.Read(messageBytes, 0, BYTESIZE);
            Console.WriteLine("[UNITY] " + CleanMessage(messageBytes));
        }

        /// <summary>
        /// This method is responsible for receiving a buffer and converting it to a ASCII message
        /// </summary>
        /// <param name="bytes">Buffer with the client message</param>
        /// <returns>String that contains ASCII message</returns>
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