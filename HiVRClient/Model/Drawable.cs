// <copyright file="Drawable.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    using System.Windows.Media.Media3D;

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
        protected Drawable(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            this.Id = id;
            this.Position = position;
            this.Rotation = rotation;
            this.Scale = scale;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the id of the drawable.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets or sets the position of this drawable.
        /// </summary>
        public Vector3D Position { get; set; }

        /// <summary>
        /// Gets or sets the rotation of this drawable.
        /// </summary>
        public Vector3D Rotation { get; set; }

        /// <summary>
        /// Gets or sets the scale of this drawable.
        /// </summary>
        public Vector3D Scale { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">the object to compare with the current object</param>
        /// <returns>whether the objects are equal</returns>
        public override bool Equals(object obj)
        {
            var drawable = obj as Drawable;
            return this.Id == drawable?.Id;
        }

        /// <summary>
        /// Serves as hash function.
        /// </summary>
        /// <returns>A semi unique identifier</returns>
        public override int GetHashCode()
        {
            return this.Id;
        }

        #endregion Methods
    }
}