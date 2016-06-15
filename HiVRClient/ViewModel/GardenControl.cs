// <copyright file="GardenControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model;

    /// <summary>
    /// This class implements the view model for a tree.
    /// </summary>
    public class GardenControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GardenControl"/> class.
        /// </summary>
        /// <param name="garden">The Garden model</param>
        public GardenControl(Garden garden) : base(garden)
        {
        }

        #endregion Constructors
    }
}