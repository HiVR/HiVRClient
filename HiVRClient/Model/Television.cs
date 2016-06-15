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