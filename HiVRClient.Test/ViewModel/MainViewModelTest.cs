// <copyright file="MainViewModelTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.ViewModel;
using NUnit.Framework;

namespace HiVRClient.Test.ViewModel
{
    /// <summary>
    /// Test <see cref="MainViewModel"/> class.
    /// </summary>
    [TestFixture]
    public class MainViewModelTest
    {
        #region Fields

        /// <summary>
        /// Contains same MainViewModel instance for each test.
        /// </summary>
        private MainViewModel mainViewModel;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a new MainViewModel instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.mainViewModel = new MainViewModel();
        }

        /// <summary>
        /// Set MainViewModel instance to null to prevent test contamination.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.mainViewModel = null;
        }

        /// <summary>
        /// Test <see cref="MainViewModel.CurrentView"/> get property.
        /// </summary>
        [Test]
        public void TestGetCurrentView()
        {
            Assert.That(this.mainViewModel.CurrentView, Is.InstanceOf<ConnectControlViewModel>());
        }

        /// <summary>
        /// Test <see cref="MainViewModel.CurrentView"/> set property.
        /// </summary>
        [Test]
        public void TestSetCurrentView()
        {
            var wasCalled = false;
            this.mainViewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName.Equals("CurrentView"))
                {
                    wasCalled = true;
                }
            };

            Assert.That(wasCalled, Is.False);
            this.mainViewModel.CurrentView = new MapViewModel();
            Assert.That(wasCalled, Is.True);
            Assert.That(this.mainViewModel.CurrentView, Is.InstanceOf<MapViewModel>());
        }

        /// <summary>
        /// Test <see cref="MainViewModel.SwitchContent"/> method.
        /// </summary>
        [Test]
        public void TestSwitchContent()
        {
            this.mainViewModel.SwitchContent();
            Assert.That(this.mainViewModel.CurrentView, Is.InstanceOf<MapViewModel>());
        }

        #endregion Methods
    }
}