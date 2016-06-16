// <copyright file="Character.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.DrawableModel
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements a character.
    /// </summary>
    public class Character : Drawable
    {
        #region Fields

        /// <summary>
        /// Gets the position of this Character.
        /// </summary>
        public static readonly Vector3D DefaultPosition = new Vector3D(0D, 0.9D, 0D);

        /// <summary>
        /// Gets the rotation of this Character.
        /// </summary>
        public static readonly Vector3D DefaultRotation = new Vector3D(0D, 0D, 0D);

        /// <summary>
        /// Gets the scale of this Character.
        /// </summary>
        public static readonly Vector3D DefaultScale = new Vector3D(0.5D, 1D, 0.5D);

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Character</param>
        /// <param name="position">the position of the Character</param>
        /// <param name="rotation">the rotation of the Character</param>
        /// <param name="scale">the scale coordinate of the Character</param>
        public Character(int id, Vector3D position, Vector3D rotation, Vector3D scale) : base(id, position, rotation, scale)
        {
        }

        #endregion Constructors
    }
}