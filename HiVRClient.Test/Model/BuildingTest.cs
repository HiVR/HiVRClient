// <copyright file="BuildingTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="Building"/> class.
    /// </summary>
    [TestFixture]
    public class BuildingTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="Building.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(Building.DefaultPosition, Is.EqualTo(new Vector3D(0D, 3D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Building.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(Building.DefaultRotation, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Building.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(Building.DefaultScale, Is.EqualTo(new Vector3D(6D, 6D, 12D)));
        }

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var building = new Building(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(building, Is.InstanceOf<Building>());
        }

        #endregion Methods
    }
}