using HiVRClient.Converter;
using NUnit.Framework;
using System.Windows;

namespace HiVRClient.Test.Converter
{
    /// <summary>
    /// Test <see cref="MarginConverter"/> class.
    /// </summary>
    [TestFixture]
    public class MarginConverterTest
    {
        #region Fields

        /// <summary>
        /// Contains margin converter instance for each test.
        /// </summary>
        private MarginConverter marginConverter;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Create a margin converter instance.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.marginConverter = new MarginConverter();
        }

        /// <summary>
        /// Set margin converter to null to prevent test contamination.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.marginConverter = null;
        }

        /// <summary>
        /// Test with valid doubles.
        /// </summary>
        [Test]
        public void TestConvertValid()
        {
            Assert.That(this.marginConverter.Convert(new object[] { 1, 2, 3, 4 }, null, null, null), Is.EqualTo(new Thickness(1, 2, 3, 4)));
        }

        /// <summary>
        /// Test not implemented convert back method.
        /// </summary>
        [Test]
        public void TestConvertBack()
        {
            Assert.That(this.marginConverter.ConvertBack(null, null, null, null), Is.Null);
        }

        #endregion Methods
    }
}