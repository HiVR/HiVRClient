// <copyright file="TelevisionTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="Television"/> class.
    /// </summary>
    [TestFixture]
    public class TelevisionTest
    {
        #region Methods

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