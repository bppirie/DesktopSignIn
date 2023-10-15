using SignIn_174CS.Core;

namespace SignIn_174CS.MVVM.ViewModel
{
    internal class SignOutViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        public SignOutViewModel(MainViewModel mainViewModel) : this()
        {
            _mainViewModel = mainViewModel;
        }

        public SignOutViewModel()
        {
        }
    }
}
