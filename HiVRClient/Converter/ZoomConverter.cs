// <copyright file="ZoomConverter.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.Converter
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    /// <summary>
    /// Converts a Binding to apply a multiplication in order to zoom.
    /// </summary>
    public class ZoomConverter : IValueConverter
    {
        /// <summary>
        /// The zoomfactor of the scaling and position of all the Drawables.
        /// </summary>
        private const double Zoom = 15;

        #region Methods
        /// <summary>
        /// Converts the value so that it zooms.
        /// </summary>
        /// <param name="value">The value before Zoom is applied.</param>
        /// <param name="targetType">The parameter is not used.</param>
        /// <param name="parameter">The parameter is not used.</param>
        /// <param name="culture">The parameter is not used.</param>
        /// <returns>The value multiplied by a zoomfactor.</returns>
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double oldValue = (double)value;
            return oldValue * Zoom;
        }

        /// <summary>
        /// Converts the value back so that it unzooms.
        /// </summary>
        /// <param name="value">The value as displayed on the map, already zoomed.</param>
        /// <param name="targetType">The parameter is not used.</param>
        /// <param name="parameter">The parameter is not used.</param>
        /// <param name="culture">The parameter is not used.</param>
        /// <returns>The value divided by a zoomfactor to return it back to the original value.</returns>
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double oldValue = (double)value;
            return oldValue / Zoom;
        }
        #endregion Methods
    }
}