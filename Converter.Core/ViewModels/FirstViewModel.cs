using MvvmCross.Core.ViewModels;

namespace Converter.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _foo;
        public string Foo
        { 
            get { return _foo; }
            set { SetProperty (ref _foo, value); }
        }
    }
}
