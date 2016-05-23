// <copyright file="RelayCommandTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
using HiVRClient.ViewModel;
using NUnit.Framework;
using Rhino.Mocks;
using System;

namespace HiVRClient.Test.ViewModel
{
    /// <summary>
    /// Test <see cref="RelayCommand" /> class.
    /// </summary>
    [TestFixture]
    public class RelayCommandTest
    {
        #region Methods

        /// <summary>
        /// Test <see cref="RelayCommand.Execute" /> method.
        /// </summary>
        [Test]
        public void TestExecute()
        {
            var action = MockRepository.GenerateMock<Action<object>>();
            RelayCommand relayCommand = new RelayCommand(action);
            var obj = new object();
            relayCommand.Execute(obj);

            action.AssertWasCalled((test) => test(obj));
        }

        /// <summary>
        /// Test <see cref="RelayCommand.CanExecute" /> method.
        /// </summary>
        [Test]
        public void TestCanExecute()
        {
            RelayCommand relayCommand = new RelayCommand(null);
            Assert.IsTrue(relayCommand.CanExecute(null));
        }

        #endregion Methods
    }
}