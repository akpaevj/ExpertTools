﻿using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace ExpertTools.Converters
{
    public class InverseBoolVisibilityCollapseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (bool)value;

            if (v)
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (Visibility)value;

            if (v == Visibility.Collapsed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
