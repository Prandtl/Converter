using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Converter.Droid.Views
{
    [Activity(Label = "Converter")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
