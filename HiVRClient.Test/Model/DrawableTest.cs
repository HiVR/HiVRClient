// <copyright file="DrawableTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

using HiVRClient.Model;
using NUnit.Framework;
using System.Windows.Media.Media3D;

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
            this.drawable = new Building(1, new Vector3D(1D, 2D, 3D), new Vector3D(4D, 5D, 6D), new Vector3D(7D, 8D, 9D));
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
        /// Test <see cref="Drawable.Position"/> get property.
        /// </summary>
        [Test]
        public void TestGetPosition()
        {
            Assert.That(this.drawable.Position, Is.EqualTo(new Vector3D(1D, 2D, 3D)));
        }

        /// <summary>
        /// Test <see cref="Drawable.Position"/> set property.
        /// </summary>
        [Test]
        public void TestSetPosition()
        {
            this.drawable.Position = new Vector3D(10D, 20D, 30D);
            Assert.That(this.drawable.Position, Is.EqualTo(new Vector3D(10D, 20D, 30D)));
        }

        /// <summary>
        /// Test <see cref="Drawable.Rotation"/> get property.
        /// </summary>
        [Test]
        public void TestGetRotation()
        {
            Assert.That(this.drawable.Rotation, Is.EqualTo(new Vector3D(4D, 5D, 6D)));
        }

        /// <summary>
        /// Test <see cref="Drawable.Rotation"/> set property.
        /// </summary>
        [Test]
        public void TestSetRotation()
        {
            this.drawable.Rotation = new Vector3D(40D, 50D, 60D);
            Assert.That(this.drawable.Rotation, Is.EqualTo(new Vector3D(40D, 50D, 60D)));
        }

        /// <summary>
        /// Test <see cref="Drawable.Scale"/> get property.
        /// </summary>
        [Test]
        public void TestGetScale()
        {
            Assert.That(this.drawable.Scale, Is.EqualTo(new Vector3D(7D, 8D, 9D)));
        }

        /// <summary>
        /// Test <see cref="Drawable.Scale"/> set property.
        /// </summary>
        [Test]
        public void TestSetScale()
        {
            this.drawable.Scale = new Vector3D(70D, 80D, 90D);
            Assert.That(this.drawable.Scale, Is.EqualTo(new Vector3D(70D, 80D, 90D)));
        }

        #endregion Methods
    }
}