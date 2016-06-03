// <copyright file="MapViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using System.Windows.Threading;
    using System.Windows;
    using System;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Contains the view model of the actual map.
    /// </summary>
    public class MapViewModel : BaseViewModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapViewModel"/> class.
        /// </summary>
        public MapViewModel()
        {
            this.Drawables = new ObservableCollection<DrawableControl>() {
                new BuildingControl(new Model.Building(0, 200, 200, 0)),
                new ActorControl(new Model.Actor(1, 400, 400, 400))
            };

            DispatcherTimer dispatcherTimer = new DispatcherTimer();

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            dispatcherTimer.Start();

            ////for testing
            DispatcherTimer otherTimer = new DispatcherTimer();

            otherTimer.Tick += new EventHandler(otherTimer_Tick);
            otherTimer.Interval = new TimeSpan(0, 0, 1);
            otherTimer.Start();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the collection of draw.
        /// </summary>
        public ObservableCollection<DrawableControl> Drawables { get; set; }

        #endregion Properties

        /// <summary>
        /// dispatcherTimer_Tick
        /// </summary>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {            
            foreach (DrawableControl dc in Drawables)
            {
                if (dc is ActorControl)
                {                    
                    ((ActorControl)dc).UpdateMapPosition();
                }                
            }
        }

        /// <summary>
        /// otherTimer_Tick
        /// </summary>
        private void otherTimer_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();

            foreach (DrawableControl dc in Drawables)
            {
                if (dc is ActorControl)
                {
                    ((ActorControl)dc).UpdatePosition(dc.XLocation + rd.Next(-30, 30), dc.YLocation + rd.Next(-30, 30));
                }                
            }
        }
    }
}