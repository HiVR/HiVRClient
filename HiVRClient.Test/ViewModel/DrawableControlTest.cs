// <copyright file="DrawableControlTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

using HiVRClient.Model;
using HiVRClient.ViewModel;
using NUnit.Framework;

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
            var drawable = new Building(1, 2, 3, 4);
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
        /// Test <see cref="DrawableControl.XLocation"/> get property.
        /// </summary>
        [Test]
        public void TestGetXLocation()
        {
            Assert.That(this.drawableControl.XLocation, Is.EqualTo(2));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.XLocation"/> set property.
        /// </summary>
        [Test]
        public void TestSetXLocation()
        {
            this.drawableControl.XLocation = 20;
            Assert.That(this.drawableControl.XLocation, Is.EqualTo(20));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.YLocation"/> get property.
        /// </summary>
        [Test]
        public void TestGetYLocation()
        {
            Assert.That(this.drawableControl.YLocation, Is.EqualTo(3));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.YLocation"/> set property.
        /// </summary>
        [Test]
        public void TestSetYLocation()
        {
            this.drawableControl.YLocation = 30;
            Assert.That(this.drawableControl.YLocation, Is.EqualTo(30));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.ZLocation"/> get property.
        /// </summary>
        [Test]
        public void TestGetZLocation()
        {
            Assert.That(this.drawableControl.ZLocation, Is.EqualTo(4));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.ZLocation"/> set property.
        /// </summary>
        [Test]
        public void TestSetZLocation()
        {
            this.drawableControl.ZLocation = 40;
            Assert.That(this.drawableControl.ZLocation, Is.EqualTo(40));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.XRotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetXRotation()
        {
            Assert.That(this.drawableControl.XRotation, Is.EqualTo(0));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.XRotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetXRotation()
        {
            this.drawableControl.XRotation = 90;
            Assert.That(this.drawableControl.XRotation, Is.EqualTo(90));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.YRotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetYRotation()
        {
            Assert.That(this.drawableControl.YRotation, Is.EqualTo(0));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.YRotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetYRotation()
        {
            this.drawableControl.YRotation = 90;
            Assert.That(this.drawableControl.YRotation, Is.EqualTo(90));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.ZRotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetZRotation()
        {
            Assert.That(this.drawableControl.ZRotation, Is.EqualTo(0));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.ZRotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetZRotation()
        {
            this.drawableControl.ZRotation = 90;
            Assert.That(this.drawableControl.ZRotation, Is.EqualTo(90));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.XScale"/> get property.
        /// </summary>
        [Test]
        public void TestGetXScale()
        {
            Assert.That(this.drawableControl.XScale, Is.EqualTo(1));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.XScale"/> set property.
        /// </summary>
        [Test]
        public void TestSetXScale()
        {
            this.drawableControl.XScale = 2;
            Assert.That(this.drawableControl.XScale, Is.EqualTo(2));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.YScale"/> get property.
        /// </summary>
        [Test]
        public void TestGetYScale()
        {
            Assert.That(this.drawableControl.YScale, Is.EqualTo(1));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.YScale"/> set property.
        /// </summary>
        [Test]
        public void TestSetYScale()
        {
            this.drawableControl.YScale = 2;
            Assert.That(this.drawableControl.YScale, Is.EqualTo(2));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.ZScale"/> get property.
        /// </summary>
        [Test]
        public void TestGetZScale()
        {
            Assert.That(this.drawableControl.ZScale, Is.EqualTo(1));
        }

        /// <summary>
        /// Test <see cref="DrawableControl.ZScale"/> set property.
        /// </summary>
        [Test]
        public void TestSetZScale()
        {
            this.drawableControl.ZScale = 2;
            Assert.That(this.drawableControl.ZScale, Is.EqualTo(2));
        }

        #endregion Methods
    }
}