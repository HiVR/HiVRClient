// <copyright file="MainViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
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
            var ccvm = new ConnectControlViewModel();
            ccvm.ConnectionAttempted += (sender, args) => { SwitchContent(); };
            this.CurrentView = ccvm;
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
        public void SwitchContent()
        {
            this.CurrentView = new MapViewModel();
        }

        #endregion Methods
    }
}