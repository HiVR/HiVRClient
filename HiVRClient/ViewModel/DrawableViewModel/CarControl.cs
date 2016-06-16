// <copyright file="CarControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel.DrawableViewModel
{
    using Model.DrawableModel;

    /// <summary>
    /// This class implements the view model for a car.
    /// </summary>
    public class CarControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CarControl"/> class.
        /// </summary>
        /// <param name="car">The car model</param>
        public CarControl(Car car) : base(car)
        {
        }

        #endregion Constructors
    }
}