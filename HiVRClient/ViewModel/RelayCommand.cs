// <copyright file="RelayCommand.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// Implements ICommand to provide commands from a view to a view model
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Fields

        /// <summary>
        /// Contains the actual command action
        /// </summary>
        private readonly Action<object> action;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand" /> class
        /// </summary>
        /// <param name="action">The action that should be executed when this command is called</param>
        public RelayCommand(Action<object> action)
        {
            this.action = action;
        }

        #endregion Constructors

        #region Events

        /// <summary>
        /// Is called when the CanExecute state changes
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion Events

        #region Methods

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="parameter">The command parameters</param>
        public void Execute(object parameter)
        {
            this.action(parameter);
        }

        /// <summary>
        /// Returns whether the command can be executed or not
        /// </summary>
        /// <param name="parameter">The command parameters</param>
        /// <returns>Whether the command can be executed or not</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        #endregion Methods
    }
}