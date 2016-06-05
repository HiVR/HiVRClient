// <copyright file="Vector3.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Utilities
{
    public class Vector3
    {
        #region Properties

        /// <summary>
        /// x value
        /// </summary>
        public double x { get; set; }

        /// <summary>
        /// y value
        /// </summary>
        public double y { get; set; }

        /// <summary>
        /// z value
        /// </summary>
        public double z { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new empty instance of the <see cref="Vector3"/> class.
        /// </summary>
        public Vector3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3"/> class.
        /// </summary>
        /// <param name="xlocation">the x value</param>
        /// <param name="ylocation">the y value</param>
        /// <param name="zlocation">the z value</param>
        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion Constructors
    }
}
