// <copyright file="TV.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a TV.
    /// </summary>
    public class TV : Drawable
    {
        #region Properties

        /// <summary>
        /// Gets the position of this TV.
        /// </summary>
        public static readonly Vector3D DefaultPosition = new Vector3D(0D, 0D, 0D);

        /// <summary>
        /// Gets the rotation of this TV.
        /// </summary>
        public static readonly Vector3D DefaultRotation = new Vector3D(0D, -180D, 0D);

        /// <summary>
        /// Gets the scale of this TV.
        /// </summary>
        public static readonly Vector3D DefaultScale = new Vector3D(1.6D, 0.9D, 1D);

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TV"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable TV</param>
        /// <param name="position">the position of the TV</param>
        /// <param name="rotation">the rotation of the TV</param>
        /// <param name="scale">the scale coordinate of the TV</param>
        public TV(int id, Vector3D position, Vector3D rotation, Vector3D scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}