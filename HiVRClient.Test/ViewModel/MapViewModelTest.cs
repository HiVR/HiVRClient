// <copyright file="MapViewModelTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

using HiVRClient.ViewModel;
using NUnit.Framework;
using System.Collections.Concurrent;

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
            Assert.That(this.mapViewModel.Drawables, Is.EqualTo(new ObservableConcurrentDictionary<int, DrawableControl>()));
        }

        #endregion Methods
    }
}