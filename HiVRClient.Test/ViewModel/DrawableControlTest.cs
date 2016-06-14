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
        /// Test <see cref="DrawableControl.position"/> get property.
        /// </summary>
        [Test]
        public void TestGetPosition()
        {
            Assert.That(this.drawableControl.position, Is.EqualTo(new Vector3D(1D, 2D, 3D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.position"/> set property.
        /// </summary>
        [Test]
        public void TestSetPosition()
        {
            this.drawableControl.position = new Vector3D(10D, 20D, 30D);
            Assert.That(this.drawableControl.position, Is.EqualTo(new Vector3D(10D, 20D, 30D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.rotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetRotation()
        {
            Assert.That(this.drawableControl.rotation, Is.EqualTo(new Vector3D(4D, 5D, 6D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.rotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetRotation()
        {
            this.drawableControl.rotation = new Vector3D(40D, 50D, 60D);
            Assert.That(this.drawableControl.rotation, Is.EqualTo(new Vector3D(40D, 50D, 60D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.scale"/> get property.
        /// </summary>
        [Test]
        public void TestGetScale()
        {
            Assert.That(this.drawableControl.scale, Is.EqualTo(new Vector3D(7D, 8D, 9D)));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.scale"/> set property.
        /// </summary>
        [Test]
        public void TestSetScale()
        {
            this.drawableControl.scale = new Vector3D(70D, 80D, 90D);
            Assert.That(this.drawableControl.scale, Is.EqualTo(new Vector3D(70D, 80D, 90D)));
        }

        #endregion Methods
    }
}