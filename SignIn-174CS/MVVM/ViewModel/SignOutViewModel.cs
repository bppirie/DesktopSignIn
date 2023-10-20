using SignIn_174CS.Core;
using SignIn_174CS.MVVM.Model;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SignIn_174CS.MVVM.ViewModel
{
    internal class SignOutViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;
        private List<SignInUser> _signedInUsers;
        public List<SignInUser> SignedInUsers
        {
            get { return _signedInUsers; }
            set
            {
                _signedInUsers = value;
                OnPropertyChanged();
            }
        }

        public SignOutViewModel(MainViewModel mainViewModel) : this()
        {
            _mainViewModel = mainViewModel;
        }

        public SignOutViewModel()
        {
            SignedInUsers = new List<SignInUser>()
            {
                new SignInUser("Test"),
                new SignInUser("Test2")
            };
        }
    }
}
