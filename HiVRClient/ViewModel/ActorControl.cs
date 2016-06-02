// <copyright file="BuildingControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model;

    /// <summary>
    /// This class implements the view model for an actor.
    /// </summary>
    public class ActorControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingControl"/> class.
        /// </summary>
        /// <param name="actor">The actor model</param>
        public ActorControl(Actor actor) : base(actor)
        {
            DisplayedXLocation = XLocation;
            DisplayedYLocation = YLocation;
        }

        #endregion Constructors

        /// <summary>
        /// Gets or sets the y-coordinate of the where the player is displayed on the map.
        /// </summary>
        public double DisplayedYLocation { get; set; }

        /// <summary>
        /// Gets or sets the x-coordinate of the where the player is displayed on the map.
        /// </summary>
        public double DisplayedXLocation { get; set; }


        /// <summary>
        /// Sets or gets the rate (between 0 and 1), indicating how fast the position displayed on the map catches up with the real position from the server
        /// </summary>
        public double UpdateRate { get; set; }

        public void UpdateMapPosition()
        {
            this.DisplayedXLocation = this.DisplayedXLocation * UpdateRate + this.XLocation * (1 - UpdateRate);
            this.DisplayedYLocation = this.DisplayedYLocation * UpdateRate + this.YLocation * (1 - UpdateRate);
            OnPropertyChanged("DisplayedXLocation");
            OnPropertyChanged("DisplayedYLocation");
        }
        public void UpdatePosition(double xLoc, double yLoc)
        {
            this.XLocation = xLoc;
            this.YLocation = yLoc;
            UpdateMapPosition();
        }
    }
}