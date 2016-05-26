// <copyright file="BuildingTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="Building"/> class.
    /// </summary>
    [TestFixture]
    public class BuildingTest
    {
        #region Fields

        /// <summary>
        /// Contains same building instance for each test.
        /// </summary>
        private Building building;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a new building instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.building = new Building(1, 2, 3, 4);
        }

        /// <summary>
        /// Set building instance to null to prevent test contamination.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.building = null;
        }

        /// <summary>
        /// Test <see cref="Building.DrawableType"/> property.
        /// </summary>
        [Test]
        public void TestDrawableType()
        {
            Assert.That(this.building.DrawableType, Is.EqualTo(DrawableType.Building));
        }

        #endregion Methods
    }
}