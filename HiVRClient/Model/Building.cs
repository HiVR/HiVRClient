// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using Utilities;

    /// <summary>
    /// This class implements a Building.
    /// </summary>
    public class Building : Drawable
    {
        #region Properties

        /// <summary>
        /// Gets the position of this Building.
        /// </summary>
        public readonly Vector3 defaultPosition = new Vector3(0D, 3D, 0D);

        /// <summary>
        /// Gets the rotation of this Building.
        /// </summary>
        public readonly Vector3 defaultRotation = new Vector3(0D, 0D, 0D);

        /// <summary>
        /// Gets the scale of this Building.
        /// </summary>
        public readonly Vector3 defaultScale = new Vector3(6D, 6D, 12D);

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Building</param>
        /// <param name="position">the position of the Building</param>
        /// <param name="rotation">the rotation of the Building</param>
        /// <param name="scale">the scale coordinate of the Building</param>
        public Building(int id, Vector3 position, Vector3 rotation, Vector3 scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}