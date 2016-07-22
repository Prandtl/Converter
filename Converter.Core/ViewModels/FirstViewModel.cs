using Converter.Core.Converters;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Converters;

namespace Converter.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		public FirstViewModel()
		{
			_course = 64.38;
			_dollarAmount = 20;
		}

		private double _course;

		public double Course
		{
			get { return _course; }
			set { SetProperty(ref _course, value); }
		}

		private double _dollarAmount;
		public double DollarAmount
		{
			get { return _dollarAmount; }
			set { SetProperty(ref _dollarAmount, value); }
		}
	}
}
