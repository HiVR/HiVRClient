// <copyright file="MainViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model.Network;

    /// <summary>
    /// Implements the main view model of the window and contains logic to switch the content.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        #region Fields

        /// <summary>
        /// Contains the current view in the content control.
        /// </summary>
        private BaseViewModel currentView;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel" /> class.
        /// </summary>
        public MainViewModel()
        {
            this.SwitchContentToConnect();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the current view in the content control.
        /// </summary>
        public BaseViewModel CurrentView
        {
            get
            {
                return this.currentView;
            }

            set
            {
                this.currentView = value;
                this.OnPropertyChanged("CurrentView");
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Switches the content to the map view after a connection has been made.
        /// </summary>
        public void SwitchContentToMap()
        {
            var mvm = new MapViewModel();
            mvm.ConnectionBroken += (sender, args) => { this.SwitchContentToConnect(); };
            this.CurrentView = mvm;
        }

        /// <summary>
        /// Switches the content to the to the connect view.
        /// </summary>
        public void SwitchContentToConnect()
        {
            var ccvm = new ConnectControlViewModel();
            ccvm.ConnectionAttempted += (sender, args) => { this.SwitchContentToMap(); };
            this.CurrentView = ccvm;
        }

        #endregion Methods
    }
}