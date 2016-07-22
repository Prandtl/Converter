using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Converter.Core.Converters
{
	public class DollarToRoubleValueConverter : MvxValueConverter<double, double>
	{
		protected override double Convert(double value, Type targetType, object parameter, CultureInfo culture)
		{
			var course = (double) parameter;
			var roubles = value*course;
			return roubles;
		}

		protected override double ConvertBack(double value, Type targetType, object parameter, CultureInfo culture)
		{
			var course = (double)parameter;
			var dollars = value / course;
			return dollars;
		}
	}
}
