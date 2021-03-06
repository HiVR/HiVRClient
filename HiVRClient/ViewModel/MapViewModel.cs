﻿// <copyright file="MapViewModel.cs" company="HiVR">
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
        /// Scale factor of the map.
        /// </summary>
        private static double mapSize = 10D;

        /// <summary>
        /// Zoom factor to zoom in and out.
        /// </summary>
        private static double zoomFactor = 1.2;

        /// <summary>
        /// Private instance of property below.
        /// </summary>
        private double zoom = 5;

        /// <summary>
        /// Private instance of property below.
        /// </summary>
        private ICommand disconnectCommand;

        /// <summary>
        /// Private instance of property below.
        /// </summary>
        private ICommand zoomInCommand;

        /// <summary>
        /// Private instance of property below.
        /// </summary>
        private ICommand zoomOutCommand;

        /// <summary>
        /// Is called when a connection is broken.
        /// </summary>
        public event EventHandler ConnectionBroken;

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
        /// Gets or sets the size of the ground map from Unity along the x-axis.
        /// </summary>
        public double MapSizeX { get; set; }

        /// <summary>
        /// Gets or sets the size of the ground map from Unity along the y-axis.
        /// </summary>
        public double MapSizeY { get; set; }

        /// <summary>
        /// Gets or sets the left offset of the map.
        /// </summary>
        public double LeftOffset { get; set; }

        /// <summary>
        /// Gets or sets the top offset of the map.
        /// </summary>
        public double TopOffset { get; set; }

        /// <summary>
        /// Gets or sets the right offset of the map.
        /// </summary>
        public double RightOffset { get; set; }

        /// <summary>
        /// Gets or sets the bottom offset of the map.
        /// </summary>
        public double BottomOffset { get; set; }

        /// <summary>
        /// Gets or sets the zoom value.
        /// </summary>
        public double Zoom
        {
            get
            {
                return this.zoom;
            }

            set
            {
                this.zoom = value;
                this.OnPropertyChanged("Zoom");
            }
        }

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
                       (this.disconnectCommand = new RelayCommand(param => this.BreakConnection()));
            }
        }

        /// <summary>
        /// Gets command interface to zoom in.
        /// </summary>
        public ICommand ZoomInCommand
        {
            get
            {
                return this.zoomInCommand ??
                    (this.zoomInCommand = new RelayCommand(param => this.ZoomAction(true)));
            }
        }

        /// <summary>
        /// Gets command interface to zoom in.
        /// </summary>
        public ICommand ZoomOutCommand
        {
            get
            {
                return this.zoomOutCommand ??
                    (this.zoomOutCommand = new RelayCommand(param => this.ZoomAction(false)));
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Add a new object to the object tracker.
        /// </summary>
        /// <param name="sender">the sender of the object received event</param>
        /// <param name="e">the object received event</param>
        private void AddObject(object sender, ObjectReceivedEventArgs e)
        {
            if (e.SerializableTransformObject.Type == SerializableType.Ground)
            {
                this.MapSizeX = e.SerializableTransformObject.Scale.X * mapSize;
                this.MapSizeY = e.SerializableTransformObject.Scale.Z * mapSize;
                this.LeftOffset = -e.SerializableTransformObject.Position.X;
                this.TopOffset = -e.SerializableTransformObject.Position.Z;
                this.RightOffset = e.SerializableTransformObject.Position.X;
                this.BottomOffset = e.SerializableTransformObject.Position.Z;
                this.OnPropertyChanged("MapSizeX");
                this.OnPropertyChanged("MapSizeY");
                this.OnPropertyChanged("LeftOffset");
                this.OnPropertyChanged("TopOffset");
                this.OnPropertyChanged("RightOffset");
                this.OnPropertyChanged("BottomOffset");
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
                }
                else
                {
                    this.Drawables.Add(drawableControl.Id, drawableControl);
                }
            }
        }

        /// <summary>
        /// Stops the connection and calls the OnConnectionBroken method.
        /// </summary>
        private void BreakConnection()
        {
            // Close the connection.
            NetworkManager.NetworkInstance.CloseConnection();

            // Actual disconnect logic here. Makes sure the ConnectionBroken Event exists and fires it.
            this.ConnectionBroken?.Invoke(this, null);
        }

        /// <summary>
        /// Zooms the map in and out.
        /// </summary>
        /// <param name="zoomIn">whether to zoom in or out</param>
        private void ZoomAction(bool zoomIn)
        {
            this.Zoom = zoomIn ? this.Zoom * zoomFactor : this.Zoom / zoomFactor;
        }

        #endregion Methods
    }
}