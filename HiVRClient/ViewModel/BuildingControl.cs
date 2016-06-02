// <copyright file="BuildingControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model;

    /// <summary>
    /// This class implements the view model for a building.
    /// </summary>
    public class BuildingControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingControl"/> class.
        /// </summary>
        /// <param name="building">he building model</param>
        public BuildingControl(Building building) : base(building)
        {
        }

        #endregion Constructors
    }
}