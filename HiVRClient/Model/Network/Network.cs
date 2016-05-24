// <copyright file="Network.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.Model.Network
{
    using System;
    using System.Net.Sockets;

    /// <summary>
    /// Contains all the logic from the network layer.
    /// </summary>
    internal class Network
    {
        #region Fields

        /// <summary>
        /// Contains the byte size used in the buffer for messages.
        /// </summary>
        private const int BYTESIZE = 1024 * 1024;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Creates the connection to the server.
        /// </summary>
        /// <param name="ip">IP to connect to</param>
        /// <param name="port">port to connect to</param>
        /// <returns>TCPClient if success or null if connection failed</returns>
        public static TcpClient CreateConnection(string ip, int port)
        {
            try
            {
                TcpClient connection = new TcpClient(ip, port);
                Console.WriteLine("Connected to Unity Server at " +
                    connection.Client.RemoteEndPoint.ToString());
                return connection;
            }
            catch (SocketException e)
            {
                Console.WriteLine("[ERROR] SocketException " + e.ToString());
                return null;
            }
        }

        #endregion Methods
    }
}