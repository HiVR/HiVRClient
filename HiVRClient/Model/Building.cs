// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a Building.
    /// </summary>
    public class Building : Drawable
    {
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