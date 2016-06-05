// <copyright file="Drawable.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using Utilities;

    /// <summary>
    /// This class implements the model of a drawable object.
    /// </summary>
    public abstract class Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Drawable"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable object</param>
        /// <param name="position">the position of the object</param>
        /// <param name="rotation">the rotation of the object</param>
        /// <param name="scale">the scale of the object</param>
        protected Drawable(int id, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            this.id = id;
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the id of the drawable.
        /// </summary>
        public int id { get; }

        /// <summary>
        /// Gets the position of this drawable.
        /// </summary>
        public Vector3 position { get; set; }

        /// <summary>
        /// Gets the rotation of this drawable.
        /// </summary>
        public Vector3 rotation { get; set; }

        /// <summary>
        /// Gets the scale of this drawable.
        /// </summary>
        public Vector3 scale { get; set; }

        #endregion Properties
    }
}