// <copyright file="TelevisionControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel.DrawableViewModel
{
    using Model.DrawableModel;

    /// <summary>
    /// This class implements the view model for a bench.
    /// </summary>
    public class TelevisionControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TelevisionControl"/> class.
        /// </summary>
        /// <param name="tv">The television model</param>
        public TelevisionControl(Television tv) : base(tv)
        {
        }

        #endregion Constructors
    }
}