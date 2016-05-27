// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a Car
    /// </summary>
    public class Car : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class
        /// </summary>
        /// <param name="id">The id of the drawable Car</param>
        /// <param name="xlocation">The x coordinate of the Car</param>
        /// <param name="ylocation">The y coordinate of the Car</param>
        /// <param name="zlocation">The z coordinate of the Car</param>
        public Car(int id, double xlocation, double ylocation, double zlocation) : base(id, DrawableType.Car, xlocation, ylocation, zlocation)
        {
        }

        #endregion Constructors
    }
}
