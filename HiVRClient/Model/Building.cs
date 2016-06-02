// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a Building.
    /// </summary>
    public class Building : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable building</param>
        /// <param name="xlocation">the x coordinate of the building</param>
        /// <param name="ylocation">the y coordinate of the building</param>
        /// <param name="zlocation">the z coordinate of the building</param>
        public Building(int id, double xlocation, double ylocation, double zlocation) : base(id, xlocation, ylocation, zlocation)
        {
        }

        #endregion Constructors
    }
}