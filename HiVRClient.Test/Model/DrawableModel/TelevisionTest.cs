// <copyright file="TelevisionTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model.DrawableModel;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model.DrawableModel
{
    /// <summary>
    /// Test <see cref="Television"/> class.
    /// </summary>
    [TestFixture]
    public class TelevisionTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="Television.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(Television.DefaultPosition, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Television.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(Television.DefaultRotation, Is.EqualTo(new Vector3D(0D, 180D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Television.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(Television.DefaultScale, Is.EqualTo(new Vector3D(1.6D, 0.9D, 1D)));
        }

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var television = new Television(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(television, Is.InstanceOf<Television>());
        }

        #endregion Methods
    }
}