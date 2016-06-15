// <copyright file="Bench.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a Bench.
    /// </summary>
    public class Bench : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Bench"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Bench</param>
        /// <param name="position">the position of the Bench</param>
        /// <param name="rotation">the rotation of the Bench</param>
        /// <param name="scale">the scale coordinate of the Bench</param>
        public Bench(int id, Vector3D position, Vector3D rotation, Vector3D scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}