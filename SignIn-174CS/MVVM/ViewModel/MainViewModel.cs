using SignIn_174CS.Core;
using System.Security.Policy;

namespace SignIn_174CS.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private object _signOutView;
        public object SignOutView
        {
            get { return _signOutView; }
            set 
            { 
                _signOutView = value;
                OnPropertyChanged();
            }

        }

        private object _signInView;
        public object SignInView
        {
            get { return _signInView; }
            set
            {
                _signInView = value;
                OnPropertyChanged();
            }

        }

        private SignInViewModel _signIn;
        private SignInCSLViewModel _signInCSL;
        private SignOutViewModel _signOut;

        public MainViewModel()
        {
            _signOut = new SignOutViewModel(this);
            _signIn = new SignInViewModel(this);
            _signInCSL = new SignInCSLViewModel(this);

            SignOutView = _signOut;
            SignInView = _signIn;
        }

        public void SetSignInCSL(bool isCSL)
        {
            if (isCSL)
            {
                SignInView = _signInCSL;
                return;
            }

            SignInView = _signIn;
        }

        public void UpdateSignOutRoster()
        {
            _signOut.Refresh();
        }
    }
}
