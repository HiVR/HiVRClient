// <copyright file="TVTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="TV"/> class.
    /// </summary>
    [TestFixture]
    public class TVTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="TV.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(TV.DefaultPosition, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="TV.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(TV.DefaultRotation, Is.EqualTo(new Vector3D(0D, 180D, 0D)));
        }

        /// <summary>
        /// Test <see cref="TV.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(TV.DefaultScale, Is.EqualTo(new Vector3D(1.6D, 0.9D, 1D)));
        }

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var tv = new TV(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(tv, Is.InstanceOf<TV>());
        }

        #endregion Methods
    }
}