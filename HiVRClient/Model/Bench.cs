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
        #region Properties

        /// <summary>
        /// Gets the position of this Bench.
        /// </summary>
        public static readonly Vector3D DefaultPosition = new Vector3D(0D, 0.2D, 0D);

        /// <summary>
        /// Gets the rotation of this Bench.
        /// </summary>
        public static readonly Vector3D DefaultRotation = new Vector3D(0D, 0D, 0D);

        /// <summary>
        /// Gets the scale of this Bench.
        /// </summary>
        public static readonly Vector3D DefaultScale = new Vector3D(0.45D, 0.4D, 1.8D);

        #endregion Properties

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