// <copyright file="MapViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using DrawableViewModel;
    using Model.Network;
    using SerializedObjects;
    using System;
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

        /// <summary>
        /// Scale factor of the map.
        /// </summary>
        private static double mapSize = 10D;

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
        /// Gets the size of the ground map from Unity along the x-axis.
        /// </summary>
        public double MapSizeX { get; set; }

        /// <summary>
        /// Gets the size of the ground map from Unity along the y-axis.
        /// </summary>
        public double MapSizeY { get; set; }

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
            if (e.SerializableTransformObject.Type == SerializableType.Ground)
            {
                this.MapSizeX = e.SerializableTransformObject.Scale.X * mapSize + 2 * Math.Abs(e.SerializableTransformObject.Position.X);
                this.MapSizeY = e.SerializableTransformObject.Scale.Z * mapSize + 2 * Math.Abs(e.SerializableTransformObject.Position.Z);
                this.OnPropertyChanged("MapSizeX");
                this.OnPropertyChanged("MapSizeY");
                return;
            }


            if (e.SerializableTransformObject.IsStatic)
            {
                var drawableControl = SerializableConverter.CreateDrawableControlFromSerializableObject(e.SerializableTransformObject);
                this.Drawables.Add(drawableControl.Id, drawableControl);
            }
            else
            {
                var drawableControl = SerializableConverter.CreateDrawableControlFromSerializableObject(e.SerializableTransformObject);
                if (this.Drawables.ContainsKey(drawableControl.Id))
                {
                    DrawableControl existing;
                    if (this.Drawables.TryGetValue(drawableControl.Id, out existing))
                    {
                        existing.UpdatePositionRotation(drawableControl.Position, drawableControl.Rotation);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Id");
                    }
                }
            }
        }

        #endregion Properties
    }
}