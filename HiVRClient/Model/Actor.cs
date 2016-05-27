// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a Actor
    /// </summary>
    public class Actor : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor"/> class
        /// </summary>
        /// <param name="id">The id of the drawable Actor</param>
        /// <param name="xlocation">The x coordinate of the Actor</param>
        /// <param name="ylocation">The y coordinate of the Actor</param>
        /// <param name="zlocation">The z coordinate of the Actor</param>
        public Actor(int id, double xlocation, double ylocation, double zlocation) : base(id, DrawableType.Actor, xlocation, ylocation, zlocation)
        {
        }
        #endregion Constructors
    }
}
