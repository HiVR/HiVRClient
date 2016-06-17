// <copyright file="CharacterTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model.DrawableModel;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model.DrawableModel
{
    /// <summary>
    /// Test <see cref="Character"/> class.
    /// </summary>
    [TestFixture]
    public class CharacterTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="Character.DefaultPosition"/> field.
        /// </summary>
        [Test]
        public void TestDefaultPosition()
        {
            Assert.That(Character.DefaultPosition, Is.EqualTo(new Vector3D(0D, 0.9D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Character.DefaultRotation"/> field.
        /// </summary>
        [Test]
        public void TestDefaultRotation()
        {
            Assert.That(Character.DefaultRotation, Is.EqualTo(new Vector3D(0D, 0D, 0D)));
        }

        /// <summary>
        /// Test <see cref="Character.DefaultScale"/> field.
        /// </summary>
        [Test]
        public void TestDefaultScale()
        {
            Assert.That(Character.DefaultScale, Is.EqualTo(new Vector3D(0.5D, 1D, 0.5D)));
        }

        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var bench = new Character(1, new Vector3D(), new Vector3D(), new Vector3D());
            Assert.That(bench, Is.InstanceOf<Character>());
        }

        #endregion Methods
    }
}