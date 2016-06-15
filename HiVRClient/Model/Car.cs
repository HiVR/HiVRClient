// <copyright file="Car.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using System.Windows.Media.Media3D;

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
        /// <param name="position">the position of the Car</param>
        /// <param name="rotation">the rotation of the Car</param>
        /// <param name="scale">the scale coordinate of the Car</param>
        public Car(int id, Vector3D position, Vector3D rotation, Vector3D scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}