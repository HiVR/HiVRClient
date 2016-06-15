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