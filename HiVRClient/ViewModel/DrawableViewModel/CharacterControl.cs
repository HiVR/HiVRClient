// <copyright file="CharacterControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel.DrawableViewModel
{
    using Model.DrawableModel;

    /// <summary>
    /// This class implements the view model for a character.
    /// </summary>
    public class CharacterControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterControl"/> class.
        /// </summary>
        /// <param name="character">The character model</param>
        public CharacterControl(Character character) : base(character)
        {
        }

        #endregion Constructors
    }
}