// <copyright file="NetworkManager.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.ViewModel
{
    using Model.Network;

    /// <summary>
    /// Contains a singleton of the network object.
    /// </summary>
    public static class NetworkManager
    {
        #region Fields

        /// <summary>
        /// Private instance of property below.
        /// </summary>
        private static Network network;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the network singleton.
        /// </summary>
        public static Network NetworkInstance => network ?? (network = new Network());

        #endregion Properties
    }
}