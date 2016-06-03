// <copyright file="TreeControl.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model;

    /// <summary>
    /// This class implements the view model for a tree.
    /// </summary>
    public class TreeControl : DrawableControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeControl"/> class.
        /// </summary>
        /// <param name="tree">The tree model</param>
        public TreeControl(Tree tree) : base(tree)
        {
        }

        #endregion Constructors
    }
}