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