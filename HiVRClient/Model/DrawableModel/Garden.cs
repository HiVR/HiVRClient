// <copyright file="Garden.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.DrawableModel
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a Garden.
    /// </summary>
    public class Garden : Drawable
    {
        #region Properties

        /// <summary>
        /// Gets the position of this Garden.
        /// </summary>
        public static readonly Vector3D DefaultPosition = new Vector3D(0D, 0.2D, 0D);

        /// <summary>
        /// Gets the rotation of this Garden.
        /// </summary>
        public static readonly Vector3D DefaultRotation = new Vector3D(0D, 0D, 0D);

        /// <summary>
        /// Gets the scale of this Garden.
        /// </summary>
        public static readonly Vector3D DefaultScale = new Vector3D(2.5D, 0.4D, 2.5D);

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Garden"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Garden</param>
        /// <param name="position">the position of the Garden</param>
        /// <param name="rotation">the rotation of the Garden</param>
        /// <param name="scale">the scale coordinate of the Garden</param>
        public Garden(int id, Vector3D position, Vector3D rotation, Vector3D scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}