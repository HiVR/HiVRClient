// <copyright file="Car.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.DrawableModel
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a Car.
    /// </summary>
    public class Car : Drawable
    {
        #region Properties

        /// <summary>
        /// Gets the position of this Car.
        /// </summary>
        public static readonly Vector3D DefaultPosition = new Vector3D(0D, 0.75D, 0D);

        /// <summary>
        /// Gets the rotation of this Car.
        /// </summary>
        public static readonly Vector3D DefaultRotation = new Vector3D(0D, 0D, 0D);

        /// <summary>
        /// Gets the scale of this Car.
        /// </summary>
        public static readonly Vector3D DefaultScale = new Vector3D(2.5D, 1.5D, 4.5D);

        #endregion Properties

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