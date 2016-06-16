// <copyright file="BenchTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model.DrawableModel;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model.DrawableModel
{
    /// <summary>
    /// Test <see cref="Bench"/> class.
    /// </summary>
    [TestFixture]
    public class BenchTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="Bench.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(Bench.DefaultPosition, Is.EqualTo(new Vector3D(0D, 0.2D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Bench.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(Bench.DefaultRotation, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Bench.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(Bench.DefaultScale, Is.EqualTo(new Vector3D(0.45D, 0.4D, 1.8D)));
        }

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