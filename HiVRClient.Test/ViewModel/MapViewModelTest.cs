// <copyright file="MapViewModelTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

using HiVRClient.Model.Network;
using HiVRClient.ViewModel;
using HiVRClient.ViewModel.DrawableViewModel;
using NUnit.Framework;
using SerializedObjects;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace HiVRClient.Test.ViewModel
{
    /// <summary>
    /// Test <see cref="MapViewModel"/> class.
    /// </summary>
    [TestFixture]
    public class MapViewModelTest
    {
        #region Fields

        /// <summary>
        /// Contains the private map view model for each test.
        /// </summary>
        private MapViewModel mapViewModel;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a new map view model instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.mapViewModel = new MapViewModel();
        }

        /// <summary>
        /// Set map view model instance to null to prevent test contamination.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.mapViewModel = null;
        }

        /// <summary>
        /// Test <see cref="MapViewModel.Drawables"/> get property.
        /// </summary>
        [Test]
        public void TestGetDrawables()
        {
            Assert.That(this.mapViewModel.Drawables, Is.Empty);
        }

        /// <summary>
        /// Test <see cref="MapViewModel.MapSizeX"/> property.
        /// </summary>
        [Test]
        public void TestMapSizeX()
        {
            this.mapViewModel.MapSizeX = 5;
            Assert.That(this.mapViewModel.MapSizeX, Is.EqualTo(5));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.MapSizeY"/> property.
        /// </summary>
        [Test]
        public void TestMapSizeY()
        {
            this.mapViewModel.MapSizeY = 5;
            Assert.That(this.mapViewModel.MapSizeY, Is.EqualTo(5));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.LeftOffset"/> property.
        /// </summary>
        [Test]
        public void TestLeftOffset()
        {
            this.mapViewModel.LeftOffset = 5;
            Assert.That(this.mapViewModel.LeftOffset, Is.EqualTo(5));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.TopOffset"/> property.
        /// </summary>
        [Test]
        public void TestTopOffset()
        {
            this.mapViewModel.TopOffset = 5;
            Assert.That(this.mapViewModel.TopOffset, Is.EqualTo(5));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.RightOffset"/> property.
        /// </summary>
        [Test]
        public void TestRightOffset()
        {
            this.mapViewModel.RightOffset = 5;
            Assert.That(this.mapViewModel.RightOffset, Is.EqualTo(5));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.BottomOffset"/> property.
        /// </summary>
        [Test]
        public void TestBottomOffset()
        {
            this.mapViewModel.BottomOffset = 5;
            Assert.That(this.mapViewModel.BottomOffset, Is.EqualTo(5));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.Zoom"/> property.
        /// </summary>
        [Test]
        public void TestZoom()
        {
            var wasCalled = false;
            this.mapViewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName.Equals("Zoom"))
                {
                    wasCalled = true;
                }
            };

            Assert.That(wasCalled, Is.False);

            this.mapViewModel.Zoom = 5;
            Assert.That(wasCalled, Is.True);
            Assert.That(this.mapViewModel.Zoom, Is.EqualTo(5));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.ZoomInCommand"/>
        /// </summary>
        [Test]
        public void TestZoomInCommand()
        {
            this.mapViewModel.Zoom = 10;
            this.mapViewModel.ZoomInCommand.Execute(null);
            Assert.That(mapViewModel.Zoom, Is.EqualTo(10 * 1.2));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.ZoomOutCommand"/>
        /// </summary>
        [Test]
        public void TestZoomOutCommand()
        {
            this.mapViewModel.Zoom = 10;
            this.mapViewModel.ZoomOutCommand.Execute(null);
            Assert.That(mapViewModel.Zoom, Is.EqualTo(10 / 1.2));
        }

        /// <summary>
        /// Test <see cref="MapViewModel.DisconnectCommand"/> property.
        /// </summary>
        [Test]
        public void TestDisconnectCommandExecute()
        {
            var wasCalled = false;
            this.mapViewModel.ConnectionBroken += (sender, args) => { wasCalled = true; };
            Assert.That(wasCalled, Is.False);

            this.mapViewModel.DisconnectCommand.Execute(null);
            Assert.That(wasCalled, Is.True);
        }

        /// <summary>
        /// Test if a ground object is received.
        /// </summary>
        [Test]
        public void TestReceiveGround()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Ground,
                true,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );
            var wasCalled = false;
            var exists = true;
            var properties = new List<string>()
                {
                    "MapSizeX",
                    "MapSizeY",
                    "LeftOffset",
                    "TopOffset",
                    "RightOffset",
                    "BottomOffset"
                };

            this.mapViewModel.PropertyChanged += (sender, args) =>
            {
                exists = exists && properties.Remove(args.PropertyName);
                wasCalled = properties.Count == 0;
            };
            Assert.That(wasCalled, Is.False);

            NetworkManager.NetworkInstance.OnObjectReceived(new ObjectReceivedEventArgs(ser));

            Assert.That(wasCalled, Is.True);
            Assert.That(exists, Is.True);
            Assert.That(this.mapViewModel.MapSizeX, Is.EqualTo(40));
            Assert.That(this.mapViewModel.MapSizeY, Is.EqualTo(60));
            Assert.That(this.mapViewModel.LeftOffset, Is.EqualTo(-1));
            Assert.That(this.mapViewModel.TopOffset, Is.EqualTo(-3));
            Assert.That(this.mapViewModel.RightOffset, Is.EqualTo(1));
            Assert.That(this.mapViewModel.BottomOffset, Is.EqualTo(3));
        }

        /// <summary>
        /// Test if static object is received.
        /// </summary>
        [Test]
        public void TestReceiveStaticObject()
        {
            var ser = new SerializableTransformObject(
                1,
                SerializableType.Building,
                true,
                new SerializableVector3(1, 2, 3),
                new SerializableVector3(4, 5, 6),
                new SerializableVector3(7, 8, 9),
                null
            );

            NetworkManager.NetworkInstance.OnObjectReceived(new ObjectReceivedEventArgs(ser));

            Assert.That(this.mapViewModel.Drawables, Is.Not.Empty);
            Assert.That(this.mapViewModel.Drawables.ContainsKey(1), Is.True);
        }

        /// <summary>
        /// Test if dynamic object is received when it doesn't exist yet.
        /// </summary>
        [Test]
        public void TestReceiveNewDynamicObject()
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

            NetworkManager.NetworkInstance.OnObjectReceived(new ObjectReceivedEventArgs(ser));

            Assert.That(this.mapViewModel.Drawables, Is.Not.Empty);
            Assert.That(this.mapViewModel.Drawables.ContainsKey(1), Is.True);
        }

        /// <summary>
        /// Test if dynamic object is received when it exists already.
        /// </summary>
        [Test]
        public void TestReceiveExistingDynamicObject()
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

            var ser2 = new SerializableTransformObject(
                1,
                SerializableType.Character,
                false,
                new SerializableVector3(10, 11, 12),
                new SerializableVector3(13, 14, 15),
                new SerializableVector3(16, 17, 18),
                new SerializableCharacter(false, "")
            );

            NetworkManager.NetworkInstance.OnObjectReceived(new ObjectReceivedEventArgs(ser));

            DrawableControl existing1, existing2;
            Assert.That(this.mapViewModel.Drawables.TryGetValue(1, out existing1), Is.True);

            NetworkManager.NetworkInstance.OnObjectReceived(new ObjectReceivedEventArgs(ser2));

            Assert.That(this.mapViewModel.Drawables.TryGetValue(1, out existing2), Is.True);
            Assert.That(existing1 == existing2, Is.True);
        }

        #endregion Methods
    }
}