// <copyright file="MapViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.ViewModel
{
    using Model.Network;
    using System.Collections.Concurrent;
    using System.Windows.Input;
    using Utility;

    /// <summary>
    /// Contains the view model of the actual map.
    /// </summary>
    public class MapViewModel : BaseViewModel
    {
        #region Fields

        /// <summary>
        /// Private instance of property below.
        /// </summary>
        private ICommand disconnectCommand;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapViewModel"/> class.
        /// </summary>
        public MapViewModel()
        {
            this.Drawables = new ObservableConcurrentDictionary<int, DrawableControl>();
            NetworkManager.NetworkInstance.ObjectReceived += this.AddObject;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the collection of draw.
        /// </summary>
        public ObservableConcurrentDictionary<int, DrawableControl> Drawables { get; }

        /// <summary>
        /// Gets command interface to connect to the menu item in the view.
        /// </summary>
        public ICommand DisconnectCommand
        {
            get
            {
                return this.disconnectCommand ??
                       (this.disconnectCommand = new RelayCommand(param => NetworkManager.NetworkInstance.CloseConnection()));
            }
        }

        /// <summary>
        /// Add a new object to the object tracker.
        /// </summary>
        /// <param name="sender">the sender of the object received event</param>
        /// <param name="e">the object received event</param>
        private void AddObject(object sender, ObjectReceivedEventArgs e)
        {
            if (e.SerializableTransformObject.IsStatic)
            {
                var drawableControl = SerializableConverter.CreateDrawableControlFromSerializableObject(e.SerializableTransformObject);
                if (drawableControl != null)
                {
                    this.Drawables.Add(drawableControl.Id, drawableControl);
                }
            }
        }

        #endregion Properties
    }
}