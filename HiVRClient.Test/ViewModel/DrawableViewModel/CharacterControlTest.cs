// <copyright file="CharacterControlTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model.DrawableModel;
using HiVRClient.ViewModel.DrawableViewModel;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.ViewModel.DrawableViewModel
{
    /// <summary>
    /// Test <see cref="CharacterControl"/> class.
    /// </summary>
    public class CharacterControlTest
    {
        #region Methods

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var id = 1;
            var position = new Vector3D(1D, 2D, 3D);
            var rotation = new Vector3D(4D, 5D, 6D);
            var rotationTest = new Vector3D(4D, -5D, 6D);
            var scale = new Vector3D(7D, 8D, 9D);
            var drawable = new Character(id, position, rotation, scale);

            var drawableControl = new CharacterControl(drawable);

            Assert.That(drawableControl.Id, Is.EqualTo(id));
            Assert.That(drawableControl.Position, Is.EqualTo(position));
            Assert.That(drawableControl.Rotation, Is.EqualTo(rotationTest));
            Assert.That(drawableControl.Scale, Is.EqualTo(scale));
        }

        #endregion Methods
    }
}