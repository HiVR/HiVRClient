// <copyright file="Drawable.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements the model of a drawable object
    /// </summary>
    public abstract class Drawable
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Drawable"/> class
        /// </summary>
        /// <param name="id">The id of the drawable object</param>
        /// <param name="type">The type of the drawable object (this is necessary for the view to determine what to draw)</param>
        /// <param name="xlocation">The x coordinate of the object</param>
        /// <param name="ylocation">The y coordinate of the object</param>
        /// <param name="zlocation">The z coordinate of the object</param>
        protected Drawable(int id, DrawableType type, double xlocation, double ylocation, double zlocation)
        {
            this.Id = id;
            this.DrawableType = type;
            this.XLocation = xlocation;
            this.YLocation = ylocation;
            this.ZLocation = zlocation;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the id of the drawable
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the type of the drawable
        /// </summary>
        public DrawableType DrawableType { get; }

        /// <summary>
        /// Gets or sets the x coordinate of the drawable
        /// </summary>
        public double XLocation { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate of the drawable
        /// </summary>
        public double YLocation { get; set; }

        /// <summary>
        /// Gets or sets the z coordinate of the drawable
        /// </summary>
        public double ZLocation { get; set; }

        /// <summary>
        /// Gets or sets the x rotation of the drawable
        /// </summary>
        public double XRotation { get; set; } = 0;

        /// <summary>
        /// Gets or sets the y rotation of the drawable
        /// </summary>
        public double YRotation { get; set; } = 0;

        /// <summary>
        /// Gets or sets the z rotation of the drawable
        /// </summary>
        public double ZRotation { get; set; } = 0;

        /// <summary>
        /// Gets or sets the x scale of the drawable
        /// </summary>
        public double XScale { get; set; } = 1;

        /// <summary>
        /// Gets or sets the y scale of the drawable
        /// </summary>
        public double YScale { get; set; } = 1;

        /// <summary>
        /// Gets or sets the z scale of the drawable
        /// </summary>
        public double ZScale { get; set; } = 1;

        #endregion Properties
    }
}