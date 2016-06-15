// <copyright file="BenchTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model
{
    /// <summary>
    /// Test <see cref="Bench"/> class.
    /// </summary>
    [TestFixture]
    public class BenchTest
    {
        #region Methods

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var bench = new Bench(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(bench, Is.InstanceOf<Bench>());
        }

        #endregion Methods
    }
}