// <copyright file="MarginConverter.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Converter
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// Converts a multibinding to apply margin offset with a zoom factor.
    /// </summary>
    [ValueConversion(typeof(double[]), typeof(Thickness))]
    public class MarginConverter : IMultiValueConverter
    {
        #region Methods

        /// <summary>
        /// Converts a array of doubles to a thickness object with a multiplication factor.
        /// </summary>
        /// <param name="values">the double array to convert</param>
        /// <param name="targetType">The parameter is not used.</param>
        /// <param name="parameter">The parameter is not used.</param>
        /// <param name="culture">The parameter is not used.</param>
        /// <returns>the thickness object</returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return new Thickness(
                    System.Convert.ToDouble(values[0]),
                    System.Convert.ToDouble(values[1]),
                    System.Convert.ToDouble(values[2]),
                    System.Convert.ToDouble(values[3]));
            }

            // Whenever we delete the MapViewModel, the Converter will try to continue updating the bindings for a short time which will trigger exceptions.
            catch (InvalidCastException)
            {
                Console.WriteLine("Expected BindingException thrown after deletion MapViewControl");

                // Return arbitrary Thickness.
                return new Thickness(0, 0, 0, 0);
            }
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="value">The parameter is not used.</param>
        /// <param name="targetTypes">The parameter is not used.</param>
        /// <param name="parameter">The parameter is not used.</param>
        /// <param name="culture">Thee parameter is not used.</param>
        /// <returns>just null</returns>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }

        #endregion Methods
    }
}