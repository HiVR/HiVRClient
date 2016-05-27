// <copyright file="NetworkManager.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.Network
{
    using System.Threading.Tasks;

    /// <summary>
    /// This class controls the Threads which handle connections to the Unity environment.
    /// </summary>
    internal class NetworkManager
    {
        #region Fields

        /// <summary>
        /// An instance of the Network class. 
        /// </summary>
        static Network network = new Network();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a connection to the Unity Environment and send and receive a test message.
        /// </summary>
        /// <param name="ip">IP to connect to</param>
        /// <param name="port">port to connect to</param>
        /// <returns>true if connection success</returns>
        public static void CreateConnection(string ip, int port)
        {
            Task.Run(() => network.Connect(ip, port));
        }

        #endregion Methods
    }
}
