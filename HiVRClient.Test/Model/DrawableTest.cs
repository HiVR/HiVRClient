// <copyright file="'DrawableTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="Drawable"/> class.
    /// </summary>
    [TestFixture]
    public class DrawableTest
    {
        #region Fields

        /// <summary>
        /// Contains same drawable instance for each test.
        /// </summary>
        private Drawable drawable;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a new drawable instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.drawable = new Building(1, 2, 3, 4);
        }

        /// <summary>
        /// Set drawable to null to prevent test contamination.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.drawable = null;
        }

        /// <summary>
        /// Test <see cref="Drawable.Id"/> property.
        /// </summary>
        [Test]
        public void TestId()
        {
            Assert.That(this.drawable.Id, Is.EqualTo(1));
        }

        /// <summary>
        /// Test <see cref="Drawable.XLocation"/> get property.
        /// </summary>
        [Test]
        public void TestGetXLocation()
        {
            Assert.That(this.drawable.XLocation, Is.EqualTo(2));
        }

        /// <summary>
        /// Test <see cref="Drawable.XLocation"/> set property.
        /// </summary>
        [Test]
        public void TestSetXLocation()
        {
            this.drawable.XLocation = 20;
            Assert.That(this.drawable.XLocation, Is.EqualTo(20));
        }

        /// <summary>
        /// Test <see cref="Drawable.YLocation"/> get property.
        /// </summary>
        [Test]
        public void TestGetYLocation()
        {
            Assert.That(this.drawable.YLocation, Is.EqualTo(3));
        }

        /// <summary>
        /// Test <see cref="Drawable.YLocation"/> set property.
        /// </summary>
        [Test]
        public void TestSetYLocation()
        {
            this.drawable.YLocation = 30;
            Assert.That(this.drawable.YLocation, Is.EqualTo(30));
        }

        /// <summary>
        /// Test <see cref="Drawable.ZLocation"/> get property.
        /// </summary>
        [Test]
        public void TestGetZLocation()
        {
            Assert.That(this.drawable.ZLocation, Is.EqualTo(4));
        }

        /// <summary>
        /// Test <see cref="Drawable.ZLocation"/> set property.
        /// </summary>
        [Test]
        public void TestSetZLocation()
        {
            this.drawable.ZLocation = 40;
            Assert.That(this.drawable.ZLocation, Is.EqualTo(40));
        }

        /// <summary>
        /// Test <see cref="Drawable.XRotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetXRotation()
        {
            Assert.That(this.drawable.XRotation, Is.EqualTo(0));
        }

        /// <summary>
        /// Test <see cref="Drawable.XRotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetXRotation()
        {
            this.drawable.XRotation = 90;
            Assert.That(this.drawable.XRotation, Is.EqualTo(90));
        }

        /// <summary>
        /// Test <see cref="Drawable.YRotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetYRotation()
        {
            Assert.That(this.drawable.YRotation, Is.EqualTo(0));
        }

        /// <summary>
        /// Test <see cref="Drawable.YRotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetYRotation()
        {
            this.drawable.YRotation = 90;
            Assert.That(this.drawable.YRotation, Is.EqualTo(90));
        }

        /// <summary>
        /// Test <see cref="Drawable.ZRotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetZRotation()
        {
            Assert.That(this.drawable.ZRotation, Is.EqualTo(0));
        }

        /// <summary>
        /// Test <see cref="Drawable.ZRotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetZRotation()
        {
            this.drawable.ZRotation = 90;
            Assert.That(this.drawable.ZRotation, Is.EqualTo(90));
        }

        /// <summary>
        /// Test <see cref="Drawable.XScale"/> get property.
        /// </summary>
        [Test]
        public void TestGetXScale()
        {
            Assert.That(this.drawable.XScale, Is.EqualTo(1));
        }

        /// <summary>
        /// Test <see cref="Drawable.XScale"/> set property.
        /// </summary>
        [Test]
        public void TestSetXScale()
        {
            this.drawable.XScale = 2;
            Assert.That(this.drawable.XScale, Is.EqualTo(2));
        }

        /// <summary>
        /// Test <see cref="Drawable.YScale"/> get property.
        /// </summary>
        [Test]
        public void TestGetYScale()
        {
            Assert.That(this.drawable.YScale, Is.EqualTo(1));
        }

        /// <summary>
        /// Test <see cref="Drawable.YScale"/> set property.
        /// </summary>
        [Test]
        public void TestSetYScale()
        {
            this.drawable.YScale = 2;
            Assert.That(this.drawable.YScale, Is.EqualTo(2));
        }

        /// <summary>
        /// Test <see cref="Drawable.ZScale"/> get property.
        /// </summary>
        [Test]
        public void TestGetZScale()
        {
            Assert.That(this.drawable.ZScale, Is.EqualTo(1));
        }

        /// <summary>
        /// Test <see cref="Drawable.ZScale"/> set property.
        /// </summary>
        [Test]
        public void TestSetZScale()
        {
            this.drawable.ZScale = 2;
            Assert.That(this.drawable.ZScale, Is.EqualTo(2));
        }

        #endregion Methods
    }
}