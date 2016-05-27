// <copyright file="MapViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Contains the view model of the actual map.
    /// </summary>
    public class MapViewModel : BaseViewModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapViewModel"/> class.
        /// </summary>
        public MapViewModel()
        {
            this.Drawables = new ObservableCollection<DrawableControl>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the collection of draw.
        /// </summary>
        public ObservableCollection<DrawableControl> Drawables { get; set; }

        #endregion Properties
    }
}