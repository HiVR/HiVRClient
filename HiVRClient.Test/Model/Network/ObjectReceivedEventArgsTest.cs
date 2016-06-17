// <copyright file="ObjectReceivedEventArgsTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.Model.Network;
using NUnit.Framework;
using SerializedObjects;

namespace HiVRClient.Test.Model.Network
{
    /// <summary>
    /// Test <see cref="ObjectReceivedEventArgs"/> class.
    /// </summary>
    [TestFixture]
    public class ObjectReceivedEventArgsTest
    {
        /// <summary>
        /// Test constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var serializableTransformObject = new SerializableTransformObject();
            var objectReceivedEventArgs = new ObjectReceivedEventArgs(serializableTransformObject);
            Assert.That(objectReceivedEventArgs, Is.InstanceOf<ObjectReceivedEventArgs>());
        }

        [Test]
        public void TestConstructorParameter()
        {
            var serializableTransformObject = new SerializableTransformObject();
            var objectReceivedEventArgs = new ObjectReceivedEventArgs(serializableTransformObject);
            Assert.That(objectReceivedEventArgs.SerializableTransformObject, Is.EqualTo(serializableTransformObject));
        }

        [Test]
        public void TestSerializableTransformObjectProperty()
        {
            var serializableTransformObject = new SerializableTransformObject();
            var objectReceivedEventArgs = new ObjectReceivedEventArgs(serializableTransformObject);

            var serializableTransformObjectTest = new SerializableTransformObject();
            objectReceivedEventArgs.SerializableTransformObject = serializableTransformObjectTest;
            Assert.That(objectReceivedEventArgs.SerializableTransformObject, Is.EqualTo(serializableTransformObjectTest));
        }
    }
}
