// <copyright file="Building.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a User
    /// </summary>
    public class User : Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class
        /// </summary>
        /// <param name="id">The id of the drawable User</param>
        /// <param name="xlocation">The x coordinate of the User</param>
        /// <param name="ylocation">The y coordinate of the User</param>
        /// <param name="zlocation">The z coordinate of the User</param>
        public User(int id, double xlocation, double ylocation, double zlocation) : base(id, DrawableType.User, xlocation, ylocation, zlocation)
        {
        }
        #endregion Constructors
    }
}
