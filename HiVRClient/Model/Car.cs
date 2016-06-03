// <copyright file="Car.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a Car.
    /// </summary>
    public class Car : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Car</param>
        /// <param name="xlocation">the x coordinate of the Car</param>
        /// <param name="ylocation">the y coordinate of the Car</param>
        /// <param name="zlocation">the z coordinate of the Car</param>
        public Car(int id, double xlocation, double ylocation, double zlocation) : base(id, xlocation, ylocation, zlocation)
        {
        }

        #endregion Constructors
    }
}