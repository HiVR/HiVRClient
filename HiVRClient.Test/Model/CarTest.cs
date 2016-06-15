// <copyright file="CarTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="Car"/> class.
    /// </summary>
    [TestFixture]
    public class CarTest
    {
        #region Methods

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var car = new Car(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(car, Is.InstanceOf<Car>());
        }

        #endregion Methods
    }
}