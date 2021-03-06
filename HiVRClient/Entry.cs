﻿// <copyright file="Entry.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient
{
    using Model.Network;
    using System;

    /// <summary>
    /// Class containing the entry point of the application.
    /// </summary>
    public static class Entry
    {
        #region Methods

        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">the arguments passed to the program</param>
        [STAThread]
        public static void Main(string[] args)
        {
            HiVRClient app = new HiVRClient();
            app.Run();
        }

        #endregion Methods
    }
}