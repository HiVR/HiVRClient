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
        /// Test <see cref="Car.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(Car.DefaultPosition, Is.EqualTo(new Vector3D(0D, 0.75D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Car.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(Car.DefaultRotation, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Car.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(Car.DefaultScale, Is.EqualTo(new Vector3D(2.5D, 1.5D, 4.5D)));
        }

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