// <copyright file="MapViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    /// <summary>
    /// Contains the view model of the actual map.
    /// </summary>
    public class MapViewModel : BaseViewModel
    {
        #region Fields

        /// <summary>
        /// Private instance of property below.
        /// </summary>
        private ICommand diconnectCommand;

        #endregion Fields

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

        /// <summary>
        /// Gets command interface to connect to the menu item in the view.
        /// </summary>
        public ICommand DisconnectCommand
        {
            get
            {
                return this.diconnectCommand ??
                       (this.diconnectCommand = new RelayCommand(param => Model.Network.NetworkManager.StopConnection()));
            }
        }

        #endregion Properties
    }
}