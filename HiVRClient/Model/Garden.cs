// <copyright file="Garden.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a Garden.
    /// </summary>
    public class Garden : Drawable
    {
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