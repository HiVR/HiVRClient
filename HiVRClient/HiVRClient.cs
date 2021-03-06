﻿// <copyright file="HiVRClient.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient
{
    using System.Windows;
    using View;

    /// <summary>
    /// The main WPF application class.
    /// </summary>
    public class HiVRClient : Application
    {
        #region Methods

        /// <summary>
        /// Override the Application startup event to show a window.
        /// </summary>
        /// <param name="e">the startup event arguments</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow mainWindow = new MainWindow();
            MainWindow.Show();
        }

        #endregion Methods
    }
}