// <copyright file="BenchControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel.DrawableViewModel
{
    using Model.DrawableModel;

    /// <summary>
    /// This class implements the view model for a bench.
    /// </summary>
    public class BenchControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchControl"/> class.
        /// </summary>
        /// <param name="bench">The bench model</param>
        public BenchControl(Bench bench) : base(bench)
        {
        }

        #endregion Constructors
    }
}