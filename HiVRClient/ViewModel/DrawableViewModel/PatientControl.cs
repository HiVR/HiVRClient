// <copyright file="PatientControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel.DrawableViewModel
{
    using Model.DrawableModel;

    /// <summary>
    /// This class implements the view model for the patient.
    /// </summary>
    public class PatientControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientControl"/> class.
        /// </summary>
        /// <param name="patient">The patient model</param>
        public PatientControl(Patient patient) : base(patient)
        {
        }

        #endregion Constructors
    }
}