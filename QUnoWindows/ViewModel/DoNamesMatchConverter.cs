// <copyright file="DoNamesMatchConverter.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.ViewModel
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class DoNamesMatchConverter : IMultiValueConverter
    {
        public DoNamesMatchConverter()
        {
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] == null || values[1] == null)
            {
                return false;
            }

            string firstName = values[0].ToString();
            string secondName = values[1].ToString();

            return String.Compare(firstName, secondName, culture, CompareOptions.IgnoreCase) == 0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
