// <copyright file="NetworkManager.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.Model.Network
{
    using Serializable;
    using System;
    using System.Collections.Generic;
    using System.Net.Sockets;
    using System.Runtime.Serialization.Formatters.Binary;

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
        /// <returns>true if connection success</returns>
        public static bool CreateConnection(string ip, int port)
        {
            server = Network.CreateConnection(ip, port);

            if (server != null)
            {
                NetworkStream stream = server.GetStream();
                ReceiveStatic(stream);

                return true;
            }
            else
            {
                // TODO: Throw error message to client for reconnecting.
                return false;
            }
        }

        /// <summary>
        /// Receive all the static objects from the server
        /// </summary>
        /// <param name="stream">the received stream that contains the elements</param>
        private static void ReceiveStatic(NetworkStream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<SerializableTransformObject> list = formatter.Deserialize(stream) as List<SerializableTransformObject>;

            foreach (SerializableTransformObject staticObject in list)
            {
                Console.Write("Static Object id: " + staticObject.id);
            }
        }

        #endregion Methods
    }
}