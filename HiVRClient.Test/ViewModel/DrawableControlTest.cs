// <copyright file="DrawableControlTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

using HiVRClient.Model;
using HiVRClient.ViewModel;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.ViewModel
{
    /// <summary>
    /// Test <see cref="DrawableControl"/> class.
    /// </summary>
    [TestFixture]
    public class DrawableControlTest
    {
        #region Fields

        /// <summary>
        /// Contains same drawable control instance for each test.
        /// </summary>
        private DrawableControl drawableControl;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a new drawable control instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            var drawable = new Building(1, new Vector3D(1D, 2D, 3D), new Vector3D(4D, 5D, 6D), new Vector3D(7D, 8D, 9D));
            this.drawableControl = new BuildingControl(drawable);
        }

        /// <summary>
        /// Set drawable and drawable control to null to prevent test contamination.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.drawableControl = null;
        }

        /// <summary>
        /// Test <see cref="DrawableControl.Position"/> get property.
        /// </summary>
        [Test]
        public void TestGetPosition()
        {
            Assert.That(this.drawableControl.Position, Is.EqualTo(new Vector3D(1D, 2D, 3D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.Position"/> set property.
        /// </summary>
        [Test]
        public void TestSetPosition()
        {
            this.drawableControl.Position = new Vector3D(10D, 20D, 30D);
            Assert.That(this.drawableControl.Position, Is.EqualTo(new Vector3D(10D, 20D, 30D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.Rotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetRotation()
        {
            Assert.That(this.drawableControl.Rotation, Is.EqualTo(new Vector3D(4D, 5D, 6D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.Rotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetRotation()
        {
            this.drawableControl.Rotation = new Vector3D(40D, 50D, 60D);
            Assert.That(this.drawableControl.Rotation, Is.EqualTo(new Vector3D(40D, 50D, 60D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.Scale"/> get property.
        /// </summary>
        [Test]
        public void TestGetScale()
        {
            Assert.That(this.drawableControl.Scale, Is.EqualTo(new Vector3D(7D, 8D, 9D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.Scale"/> set property.
        /// </summary>
        [Test]
        public void TestSetScale()
        {
            this.drawableControl.Scale = new Vector3D(70D, 80D, 90D);
            Assert.That(this.drawableControl.Scale, Is.EqualTo(new Vector3D(70D, 80D, 90D)));
        }

        #endregion Methods
    }
}