// <copyright file="GardenTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="Garden"/> class.
    /// </summary>
    [TestFixture]
    public class GardenTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="Garden.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(Garden.DefaultPosition, Is.EqualTo(new Vector3D(0D, 0.2D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Garden.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(Garden.DefaultRotation, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Garden.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(Garden.DefaultScale, Is.EqualTo(new Vector3D(2.5D, 0.4D, 2.5D)));
        }

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var garden = new Garden(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(garden, Is.InstanceOf<Garden>());
        }

        #endregion Methods
    }
}