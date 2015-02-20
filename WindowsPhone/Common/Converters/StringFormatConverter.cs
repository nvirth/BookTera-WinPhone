﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace WindowsPhone.Common.Converters
{
	public sealed class StringFormatConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if(value == null)
				return null;

			if(parameter == null)
				return value;

			return string.Format(culture, (string)parameter, value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
