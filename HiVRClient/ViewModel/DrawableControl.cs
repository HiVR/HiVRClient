// <copyright file="DrawableControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model;

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
        /// Gets or sets the x location of the drawable.
        /// </summary>
        public double XLocation
        {
            get { return this.drawable.XLocation; }
            set { this.drawable.XLocation = value; }
        }

        /// <summary>
        /// Gets or sets the y location of the drawable.
        /// </summary>
        public double YLocation
        {
            get { return this.drawable.YLocation; }
            set { this.drawable.YLocation = value; }
        }

        /// <summary>
        /// Gets or sets the z location of the drawable.
        /// </summary>
        public double ZLocation
        {
            get { return this.drawable.ZLocation; }
            set { this.drawable.ZLocation = value; }
        }

        /// <summary>
        /// Gets or sets the x rotation of the drawable.
        /// </summary>
        public double XRotation
        {
            get { return this.drawable.XRotation; }
            set { this.drawable.XRotation = value; }
        }

        /// <summary>
        /// Gets or sets the y rotation of the drawable.
        /// </summary>
        public double YRotation
        {
            get { return this.drawable.YRotation; }
            set { this.drawable.YRotation = value; }
        }

        /// <summary>
        /// Gets or sets the z location of the drawable.
        /// </summary>
        public double ZRotation
        {
            get { return this.drawable.ZRotation; }
            set { this.drawable.ZRotation = value; }
        }

        /// <summary>
        /// Gets or sets the x scale of the drawable.
        /// </summary>
        public double XScale
        {
            get { return this.drawable.XScale; }
            set { this.drawable.XScale = value; }
        }

        /// <summary>
        /// Gets or sets the y scale of the drawable.
        /// </summary>
        public double YScale
        {
            get { return this.drawable.YScale; }
            set { this.drawable.YScale = value; }
        }

        /// <summary>
        /// Gets or sets the z scale of the drawable.
        /// </summary>
        public double ZScale
        {
            get { return this.drawable.ZScale; }
            set { this.drawable.ZScale = value; }
        }

        #endregion Properties
    }
}