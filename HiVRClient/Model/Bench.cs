// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a Bench
    /// </summary>
    public class Bench : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Bench"/> class
        /// </summary>
        /// <param name="id">The id of the drawable Bench</param>
        /// <param name="xlocation">The x coordinate of the Bench</param>
        /// <param name="ylocation">The y coordinate of the Bench</param>
        /// <param name="zlocation">The z coordinate of the Bench</param>
        public Bench(int id, double xlocation, double ylocation, double zlocation) : base(id, DrawableType.Bench, xlocation, ylocation, zlocation)
        {
        }

        #endregion Constructors
    }
}
