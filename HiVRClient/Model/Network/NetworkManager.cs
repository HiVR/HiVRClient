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
        /// Port that the server will listen to
        /// Editable in Unity
        /// </summary>
        private const int PORT = 25565;

        /// <summary>
        /// Contains the active client object
        /// </summary>
        private static TcpClient server;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a connection to the Unity Environment and send and receive a test message
        /// </summary>
        public static void CreateConnection()
        {
            server = new TcpClient("127.0.0.1", PORT); // Create a new connection
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