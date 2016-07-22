using System;
using System.Globalization;
using System.Linq;
using System.Text;
using MvvmCross.Platform.Converters;

namespace Converter.Core.Converters
{
	public class StringReverseValueConverter: MvxValueConverter<string, string>
	{
		protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
			return Reverse(value);
		}

		protected override string ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
		{
			return Reverse(value);
		}

		private static string Reverse(string input)
		{
			input = input ?? "";
			var builder = new StringBuilder();
			for (int i = input.Length - 1; i >= 0; i--)
			{
				builder.Append(input[i]);
			}
			var reversed = builder.ToString();
			return reversed;
		}
	}
}
