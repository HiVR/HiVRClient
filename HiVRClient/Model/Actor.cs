// <copyright file="actor.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a actor.
    /// </summary>
    public class Actor : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable actor</param>
        /// <param name="xlocation">the x coordinate of the actor</param>
        /// <param name="ylocation">the y coordinate of the actor</param>
        /// <param name="zlocation">the z coordinate of the actor</param>
        public Actor(int id, double xlocation, double ylocation, double zlocation) : base(id, DrawableType.Actor, xlocation, ylocation, zlocation)
        {
        }

        #endregion Constructors
    }
}