// <copyright file="ActorControl.cs" company="HiVR">
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
        /// Initializes a new instance of the <see cref="ActorControl"/> class.
        /// </summary>
        /// <param name="actor">The actor model</param>
        public ActorControl(Actor actor) : base(actor)
        {
            this.DisplayedXLocation = this.XLocation;
            this.DisplayedYLocation = this.YLocation;
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
        public double UpdateRate { get; set; } = 0.05;

        /// <summary>
        /// Updates the position of the object in the XY coordinates of the map
        /// </summary>
        public void UpdateMapPosition()
        {
            this.DisplayedXLocation = this.DisplayedXLocation * this.UpdateRate + this.XLocation * (1 - UpdateRate);
            this.DisplayedYLocation = this.DisplayedYLocation * this.UpdateRate + this.YLocation * (1 - UpdateRate);
            this.OnPropertyChanged("DisplayedXLocation");
            this.OnPropertyChanged("DisplayedYLocation");
        }

        /// <summary>
        /// UpdatesMapPosition for X and Y.
        /// <param name="xLoc">The X coordinate</param>
        /// <param name="yLoc">The Y coordinate</param>
        /// </summary>
        public void UpdatePosition(double xLoc, double yLoc)
        {
            this.XLocation = xLoc;
            this.YLocation = yLoc;
            //UpdateMapPosition();
        }
    }
}