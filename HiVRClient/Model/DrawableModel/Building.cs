// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.DrawableModel
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a Building.
    /// </summary>
    public class Building : Drawable
    {
        #region Fields

        /// <summary>
        /// Gets the position of this Building.
        /// </summary>
        public static readonly Vector3D DefaultPosition = new Vector3D(0D, 3D, 0D);

        /// <summary>
        /// Gets the rotation of this Building.
        /// </summary>
        public static readonly Vector3D DefaultRotation = new Vector3D(0D, 0D, 0D);

        /// <summary>
        /// Gets the scale of this Building.
        /// </summary>
        public static readonly Vector3D DefaultScale = new Vector3D(6D, 6D, 12D);

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Building</param>
        /// <param name="position">the position of the Building</param>
        /// <param name="rotation">the rotation of the Building</param>
        /// <param name="scale">the scale coordinate of the Building</param>
        public Building(int id, Vector3D position, Vector3D rotation, Vector3D scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}