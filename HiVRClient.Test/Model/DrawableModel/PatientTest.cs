// <copyright file="PatientTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model.DrawableModel;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model.DrawableModel
{
    /// <summary>
    /// Test <see cref="Patient"/> class.
    /// </summary>
    [TestFixture]
    public class PatientTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="Patient.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(Patient.DefaultPosition, Is.EqualTo(new Vector3D(0D, 0.9D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Patient.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(Patient.DefaultRotation, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Patient.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(Patient.DefaultScale, Is.EqualTo(new Vector3D(0.5D, 1D, 0.5D)));
        }

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var bench = new Patient(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(bench, Is.InstanceOf<Patient>());
        }

        #endregion Methods
    }
}