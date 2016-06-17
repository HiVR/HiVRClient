// <copyright file="DrawableFactoryTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model.DrawableModel;
using NUnit.Framework;
using System.Windows.Media.Media3D;

namespace HiVRClient.Test.Model.DrawableModel
{
    /// <summary>
    /// Test <see cref="DrawableFactory"/> class.
    /// </summary>
    [TestFixture]
    public class DrawableFactoryTest
    {
        #region Fields

        /// <summary>
        /// Instance of the class that gets tested.
        /// </summary>
        private DrawableFactory factory = new DrawableFactory();

        /// <summary>
        /// Test id that will be used in every test for this class.
        /// </summary>
        private int id = 1;

        /// <summary>
        /// Test value that will be used in every test for this class.
        /// </summary>
        private Vector3D vector = new Vector3D(0D, 1D, 2D);

        #endregion Fields

        #region Methods

        /// <summary>
        /// Test <see cref="DrawableFactory.GetBuilding(int, Vector3D, Vector3D, Vector3D)"/> method.
        /// </summary>
        [Test]
        public void TestGetBuilding()
        {
            var res = this.factory.GetBuilding(this.id, this.vector, this.vector, this.vector);

            Assert.That(res.Id, Is.EqualTo(this.id));

            Assert.That(res.Position.X, Is.EqualTo(Building.DefaultPosition.X));
            Assert.That(res.Position.Y, Is.EqualTo(Building.DefaultPosition.Y + this.vector.Y));
            Assert.That(res.Position.Z, Is.EqualTo(Building.DefaultPosition.Z + this.vector.Z));

            Assert.That(res.Rotation.X, Is.EqualTo(Building.DefaultRotation.X));
            Assert.That(res.Rotation.Y, Is.EqualTo(Building.DefaultRotation.Y + this.vector.Y));
            Assert.That(res.Rotation.Z, Is.EqualTo(Building.DefaultRotation.Z + this.vector.Z));

            Assert.That(res.Scale.X, Is.EqualTo(0D));
            Assert.That(res.Scale.Y, Is.EqualTo(Building.DefaultScale.Y));
            Assert.That(res.Scale.Z, Is.EqualTo(Building.DefaultScale.Z * this.vector.Z));
        }

        /// <summary>
        /// Test <see cref="DrawableFactory.GetBench(int, Vector3D, Vector3D, Vector3D)"/> method.
        /// </summary>
        [Test]
        public void TestGetBench()
        {
            var res = this.factory.GetBench(this.id, this.vector, this.vector, this.vector);

            Assert.That(res.Id, Is.EqualTo(this.id));

            Assert.That(res.Position.X, Is.EqualTo(Bench.DefaultPosition.X));
            Assert.That(res.Position.Y, Is.EqualTo(Bench.DefaultPosition.Y + this.vector.Y));
            Assert.That(res.Position.Z, Is.EqualTo(Bench.DefaultPosition.Z + this.vector.Z));

            Assert.That(res.Rotation.X, Is.EqualTo(Bench.DefaultRotation.X));
            Assert.That(res.Rotation.Y, Is.EqualTo(Bench.DefaultRotation.Y + this.vector.Y));
            Assert.That(res.Rotation.Z, Is.EqualTo(Bench.DefaultRotation.Z + this.vector.Z));

            Assert.That(res.Scale.X, Is.EqualTo(0D));
            Assert.That(res.Scale.Y, Is.EqualTo(Bench.DefaultScale.Y));
            Assert.That(res.Scale.Z, Is.EqualTo(Bench.DefaultScale.Z * this.vector.Z));
        }

        /// <summary>
        /// Test <see cref="DrawableFactory.GetCar(int, Vector3D, Vector3D, Vector3D)"/> method.
        /// </summary>
        [Test]
        public void TestGetCar()
        {
            var res = this.factory.GetCar(this.id, this.vector, this.vector, this.vector);

            Assert.That(res.Id, Is.EqualTo(this.id));

            Assert.That(res.Position.X, Is.EqualTo(Car.DefaultPosition.X));
            Assert.That(res.Position.Y, Is.EqualTo(Car.DefaultPosition.Y + this.vector.Y));
            Assert.That(res.Position.Z, Is.EqualTo(Car.DefaultPosition.Z + this.vector.Z));

            Assert.That(res.Rotation.X, Is.EqualTo(Car.DefaultRotation.X));
            Assert.That(res.Rotation.Y, Is.EqualTo(Car.DefaultRotation.Y + this.vector.Y));
            Assert.That(res.Rotation.Z, Is.EqualTo(Car.DefaultRotation.Z + this.vector.Z));

            Assert.That(res.Scale.X, Is.EqualTo(0D));
            Assert.That(res.Scale.Y, Is.EqualTo(Car.DefaultScale.Y));
            Assert.That(res.Scale.Z, Is.EqualTo(Car.DefaultScale.Z * this.vector.Z));
        }

        /// <summary>
        /// Test <see cref="DrawableFactory.GetGarden(int, Vector3D, Vector3D, Vector3D)"/> method.
        /// </summary>
        [Test]
        public void TestGetGarden()
        {
            var res = this.factory.GetGarden(this.id, this.vector, this.vector, this.vector);

            Assert.That(res.Id, Is.EqualTo(this.id));

            Assert.That(res.Position.X, Is.EqualTo(Garden.DefaultPosition.X));
            Assert.That(res.Position.Y, Is.EqualTo(Garden.DefaultPosition.Y + this.vector.Y));
            Assert.That(res.Position.Z, Is.EqualTo(Garden.DefaultPosition.Z + this.vector.Z));

            Assert.That(res.Rotation.X, Is.EqualTo(Garden.DefaultRotation.X));
            Assert.That(res.Rotation.Y, Is.EqualTo(Garden.DefaultRotation.Y + this.vector.Y));
            Assert.That(res.Rotation.Z, Is.EqualTo(Garden.DefaultRotation.Z + this.vector.Z));

            Assert.That(res.Scale.X, Is.EqualTo(0D));
            Assert.That(res.Scale.Y, Is.EqualTo(Garden.DefaultScale.Y));
            Assert.That(res.Scale.Z, Is.EqualTo(Garden.DefaultScale.Z * this.vector.Z));
        }

        /// <summary>
        /// Test <see cref="DrawableFactory.GetTelevision(int, Vector3D, Vector3D, Vector3D)"/> method.
        /// </summary>
        [Test]
        public void TestGetTelevision()
        {
            var res = this.factory.GetTelevision(this.id, this.vector, this.vector, this.vector);

            Assert.That(res.Id, Is.EqualTo(this.id));

            Assert.That(res.Position.X, Is.EqualTo(Television.DefaultPosition.X));
            Assert.That(res.Position.Y, Is.EqualTo(Television.DefaultPosition.Y + this.vector.Y));
            Assert.That(res.Position.Z, Is.EqualTo(Television.DefaultPosition.Z + this.vector.Z));

            Assert.That(res.Rotation.X, Is.EqualTo(Television.DefaultRotation.X));
            Assert.That(res.Rotation.Y, Is.EqualTo(Television.DefaultRotation.Y + this.vector.Y));
            Assert.That(res.Rotation.Z, Is.EqualTo(Television.DefaultRotation.Z + this.vector.Z));

            Assert.That(res.Scale.X, Is.EqualTo(0D));
            Assert.That(res.Scale.Y, Is.EqualTo(Television.DefaultScale.Y));
            Assert.That(res.Scale.Z, Is.EqualTo(Television.DefaultScale.Z * this.vector.Z));
        }

        /// <summary>
        /// Test <see cref="DrawableFactory.GetCharacter(int, Vector3D, Vector3D, Vector3D)"/> method.
        /// </summary>
        [Test]
        public void TestGetCharacter()
        {
            var res = this.factory.GetCharacter(this.id, this.vector, this.vector, this.vector);

            Assert.That(res.Id, Is.EqualTo(this.id));

            Assert.That(res.Position.X, Is.EqualTo(Character.DefaultPosition.X));
            Assert.That(res.Position.Y, Is.EqualTo(Character.DefaultPosition.Y + this.vector.Y));
            Assert.That(res.Position.Z, Is.EqualTo(Character.DefaultPosition.Z + this.vector.Z));

            Assert.That(res.Rotation.X, Is.EqualTo(Character.DefaultRotation.X));
            Assert.That(res.Rotation.Y, Is.EqualTo(Character.DefaultRotation.Y + this.vector.Y));
            Assert.That(res.Rotation.Z, Is.EqualTo(Character.DefaultRotation.Z + this.vector.Z));

            Assert.That(res.Scale.X, Is.EqualTo(0D));
            Assert.That(res.Scale.Y, Is.EqualTo(Character.DefaultScale.Y));
            Assert.That(res.Scale.Z, Is.EqualTo(Character.DefaultScale.Z * this.vector.Z));
        }

        /// <summary>
        /// Test <see cref="DrawableFactory.GetPatient(int, Vector3D, Vector3D, Vector3D)"/> method.
        /// </summary>
        [Test]
        public void TestGetPatient()
        {
            var res = this.factory.GetPatient(this.id, this.vector, this.vector, this.vector);

            Assert.That(res.Id, Is.EqualTo(this.id));

            Assert.That(res.Position.X, Is.EqualTo(Patient.DefaultPosition.X));
            Assert.That(res.Position.Y, Is.EqualTo(Patient.DefaultPosition.Y + this.vector.Y));
            Assert.That(res.Position.Z, Is.EqualTo(Patient.DefaultPosition.Z + this.vector.Z));

            Assert.That(res.Rotation.X, Is.EqualTo(Patient.DefaultRotation.X));
            Assert.That(res.Rotation.Y, Is.EqualTo(-(Patient.DefaultRotation.Y + this.vector.Y)));
            Assert.That(res.Rotation.Z, Is.EqualTo(-(Patient.DefaultRotation.Z + this.vector.Z)));

            Assert.That(res.Scale.X, Is.EqualTo(0D));
            Assert.That(res.Scale.Y, Is.EqualTo(Patient.DefaultScale.Y));
            Assert.That(res.Scale.Z, Is.EqualTo(Patient.DefaultScale.Z * this.vector.Z));
        }

        #endregion Methods
    }
}