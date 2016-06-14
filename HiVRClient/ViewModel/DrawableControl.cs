// <copyright file="DrawableControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model;
    using System.Windows.Media.Media3D;

    /// <summary>
    /// This class implements the view model for the <see cref="Drawable"/> class.
    /// </summary>
    public abstract class DrawableControl : BaseViewModel
    {
        #region Fields

        /// <summary>
        /// Contains the drawable for this view model.
        /// </summary>
        private Drawable drawable;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawableControl"/> class.
        /// </summary>
        /// <param name="drawable">the drawable this class is a view model for</param>
        protected DrawableControl(Drawable drawable)
        {
            this.drawable = drawable;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the position of the drawable.
        /// </summary>
        public Vector3D Position
        {
            get { return this.drawable.Position; }
            set { this.drawable.Position = value; }
        }

        /// <summary>
        /// Gets or sets the rotation of the drawable.
        /// </summary>
        public Vector3D Rotation
        {
            get { return this.drawable.Rotation; }
            set { this.drawable.Rotation = value; }
        }

        /// <summary>
        /// Gets or sets the scale of the drawable.
        /// </summary>
        public Vector3D Scale
        {
            get { return this.drawable.Scale; }
            set { this.drawable.Scale = value; }
        }

        #endregion Properties
    }
}