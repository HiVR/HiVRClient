// <copyright file="ConnectControlViewModelTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.ViewModel;
using NUnit.Framework;

namespace HiVRClient.Test.ViewModel
{
    /// <summary>
    /// Test <see cref="ConnectControlViewModel"/> class.
    /// </summary>
    [TestFixture]
    public class ConnectControlViewModelTest
    {
        #region Fields

        /// <summary>
        /// Contains same ConnectControlViewModel instance for each test.
        /// </summary>
        private ConnectControlViewModel connectControlViewModel;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a new ConnectControlViewModel instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.connectControlViewModel = new ConnectControlViewModel();
        }

        /// <summary>
        /// Set ConnectControlViewModel instance to null to prevent test contamination.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.connectControlViewModel = null;
        }

        /// <summary>
        /// Test <see cref="ConnectControlViewModel.Host"/> get property.
        /// </summary>
        [Test]
        public void TestGetHost()
        {
            Assert.That(this.connectControlViewModel.Host, Is.Empty);
        }

        /// <summary>
        /// Test <see cref="ConnectControlViewModel.Host"/> set property.
        /// </summary>
        [Test]
        public void TestSetHost()
        {
            this.connectControlViewModel.Host = "test";
            Assert.That(this.connectControlViewModel.Host, Is.EqualTo("test"));
        }

        /// <summary>
        /// Test <see cref="ConnectControlViewModel.Port"/> get property.
        /// </summary>
        [Test]
        public void TestGetPort()
        {
            Assert.That(this.connectControlViewModel.Port, Is.EqualTo(25565));
        }

        /// <summary>
        /// Test <see cref="ConnectControlViewModel.Port"/> set property.
        /// </summary>
        [Test]
        public void TestSetPort()
        {
            this.connectControlViewModel.Port = 100;
            Assert.That(this.connectControlViewModel.Port, Is.EqualTo(100));
        }

        /// <summary>
        /// Test <see cref="ConnectControlViewModel.ConnectCommand"/> property.
        /// </summary>
        [Test]
        public void TestConnectCommandExecute()
        {
            var wasCalled = false;
            this.connectControlViewModel.ConnectionAttempted += (sender, args) => { wasCalled = true; };
            Assert.That(wasCalled, Is.False);

            this.connectControlViewModel.ConnectCommand.Execute(null);
            Assert.That(wasCalled, Is.True);
        }

        #endregion Methods
    }
}