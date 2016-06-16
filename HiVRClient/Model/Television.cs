// <copyright file="Television.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a Television.
    /// </summary>
    public class Television : Drawable
    {
        #region Properties

        /// <summary>
        /// Gets the position of this Television.
        /// </summary>
        public static readonly Vector3D DefaultPosition = new Vector3D(0D, 0D, 0D);

        /// <summary>
        /// Gets the rotation of this Television.
        /// </summary>
        public static readonly Vector3D DefaultRotation = new Vector3D(0D, 180D, 0D);

        /// <summary>
        /// Gets the scale of this Television.
        /// </summary>
        public static readonly Vector3D DefaultScale = new Vector3D(1.6D, 0.9D, 1D);

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Television"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Television</param>
        /// <param name="position">the position of the Television</param>
        /// <param name="rotation">the rotation of the Television</param>
        /// <param name="scale">the scale coordinate of the Television</param>
        public Television(int id, Vector3D position, Vector3D rotation, Vector3D scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}