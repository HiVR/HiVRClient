// <copyright file="Tree.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a Tree.
    /// </summary>
    public class Tree : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Tree"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Tree</param>
        /// <param name="xlocation">the x coordinate of the Tree</param>
        /// <param name="ylocation">the y coordinate of the Tree</param>
        /// <param name="zlocation">the z coordinate of the Tree</param>
        public Tree(int id, double xlocation, double ylocation, double zlocation) : base(id, xlocation, ylocation, zlocation)
        {
        }

        #endregion Constructors
    }
}