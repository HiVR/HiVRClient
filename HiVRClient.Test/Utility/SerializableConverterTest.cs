using HiVRClient.Utility;
using HiVRClient.ViewModel.DrawableViewModel;
using NUnit.Framework;
using SerializedObjects;
using System;

namespace HiVRClient.Test.Utility
{
    /// <summary>
    /// Test <see cref="SerializableConverter"/> class.
    /// </summary>
    [TestFixture]
    public class SerializableConverterTest
    {
        #region Methods

        /// <summary>
        /// Test creating a building.
        /// </summary>
        [Test]
        public void TestCreateBuilding()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Building,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );

            var result = SerializableConverter.CreateDrawableControlFromSerializableObject(ser);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<BuildingControl>());
        }

        /// <summary>
        /// Test creating a car.
        /// </summary>
        [Test]
        public void TestCreateCar()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Car,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );

            var result = SerializableConverter.CreateDrawableControlFromSerializableObject(ser);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<CarControl>());
        }

        /// <summary>
        /// Test creating a garden.
        /// </summary>
        [Test]
        public void TestCreateGarden()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Garden,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );

            var result = SerializableConverter.CreateDrawableControlFromSerializableObject(ser);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<GardenControl>());
        }

        /// <summary>
        /// Test creating a bench.
        /// </summary>
        [Test]
        public void TestCreateBench()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Bench,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );

            var result = SerializableConverter.CreateDrawableControlFromSerializableObject(ser);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<BenchControl>());
        }

        /// <summary>
        /// Test creating a television.
        /// </summary>
        [Test]
        public void TestCreateTelevision()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Television,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );

            var result = SerializableConverter.CreateDrawableControlFromSerializableObject(ser);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<TelevisionControl>());
        }

        /// <summary>
        /// Test creating a character.
        /// </summary>
        [Test]
        public void TestCreateCharacter()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Character,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                new SerializableCharacter(false, "")
            );

            var result = SerializableConverter.CreateDrawableControlFromSerializableObject(ser);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<CharacterControl>());
        }

        /// <summary>
        /// Test creating a patient.
        /// </summary>
        [Test]
        public void TestCreatePatient()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Character,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                new SerializableCharacter(true, "")
            );

            var result = SerializableConverter.CreateDrawableControlFromSerializableObject(ser);

            Assert.That(result.Id, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<PatientControl>());
        }

        /// <summary>
        /// Test creating an invalid object.
        /// </summary>
        [Test]
        public void TestCreateInvalid()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Unknown,
                false,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                SerializableConverter.CreateDrawableControlFromSerializableObject(ser);
            });
        }

        /// <summary>
        /// Test <see cref="SerializableConverter.ConvertSerializableVector3ToVector3D"/> method.
        /// </summary>
        [Test]
        public void TestConvertSerializableVector()
        {
            var vec = new SerializableVector3(1, 2, 3);
            var toVec = SerializableConverter.ConvertSerializableVector3ToVector3D(vec);

            Assert.That(toVec.X, Is.EqualTo(1));
            Assert.That(toVec.Y, Is.EqualTo(2));
            Assert.That(toVec.Z, Is.EqualTo(3));
        }

        #endregion Methods
    }
}