// <copyright file="DrawableControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel.DrawableViewModel
{
    using Model.DrawableModel;
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
        /// Gets the id of the drawable.
        /// </summary>
        public int Id => this.drawable.Id;

        /// <summary>
        /// Gets or sets the position of the drawable.
        /// </summary>
        public Vector3D Position => this.drawable.Position;

        /// <summary>
        /// Gets or sets the rotation of the drawable.
        /// </summary>
        public Vector3D Rotation => new Vector3D(this.drawable.Rotation.X, -this.drawable.Rotation.Y, this.drawable.Rotation.Z);

        /// <summary>
        /// Gets or sets the scale of the drawable.
        /// </summary>
        public Vector3D Scale => this.drawable.Scale;

        #endregion Properties

        #region Methods

        /// <summary>
        /// Update position and rotation of the drawable.
        /// </summary>
        /// <param name="position">the new position</param>
        /// <param name="rotation">the new rotation</param>
        public void UpdatePositionRotation(Vector3D position, Vector3D rotation)
        {
            if (!(this.Position.Equals(position) && this.Rotation.Equals(rotation)))
            {
                this.drawable.Position = position;
                this.drawable.Rotation = rotation;
                this.OnPropertyChanged("Position");
                this.OnPropertyChanged("Rotation");
            }
        }

        #endregion Methods
    }
}