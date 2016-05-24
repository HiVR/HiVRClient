// <copyright file="NetworkManager.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.Network
{
    using System;
    using System.Net.Sockets;
    using System.Runtime.Serialization.Formatters.Binary;
    using Serializable;
    using System.Collections.Generic;

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
            try
            {
                server = new TcpClient(ip, port); // Create a new connection
                Console.WriteLine("Connected to Unity Server at " + server.Client.LocalEndPoint.ToString());

                NetworkStream stream = server.GetStream();

                BinaryFormatter formatter = new BinaryFormatter();
                List<SerializableTransformObject> list = formatter.Deserialize(stream) as List<SerializableTransformObject>;

                foreach (SerializableTransformObject staticObject in list)
                {
                    Console.Write("Static Object id: " + staticObject.id);
                }

            }
            catch (SocketException e)
            {
                Console.WriteLine("[ERROR] SocketException!");
            }
        }

        #endregion Methods
    }
}