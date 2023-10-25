using SignIn_174CS.Core;
using SignIn_174CS.Helpers;
using SignIn_174CS.MVVM.Model;
using System;
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

        public RelayCommand SignOutUser { get; set; }

        public SignOutViewModel(MainViewModel mainViewModel) : this()
        {
            _mainViewModel = mainViewModel;
        }

        public SignOutViewModel()
        {
            /*SignedInUsers = new List<SignInUser>()
            {
                new SignInUser("", "", "Test", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, true),
                new SignInUser("", "", "Test2", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, false),
                new SignInUser("", "", "Test", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, true),
                new SignInUser("", "", "Test2", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, false),
                new SignInUser("", "", "Test", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, true),
                new SignInUser("", "", "Test2", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, false),
                new SignInUser("", "", "Test", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, true),
                new SignInUser("", "", "Test2", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, false),
                new SignInUser("", "", "Test", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, true),
                new SignInUser("", "", "Test2", "", "This computer doesnt work", "", DateTime.Now.ToString(), "", "", false, false)
            };*/

            SignedInUsers = CSVHelper.GetSignedInUsers();

            SignOutUser = new RelayCommand(o =>
            {
                string guid = o as string;
                CSVHelper.UpdateCSV(guid, "", "");
                Refresh();
            });
        }

        public void Refresh()
        {
            SignedInUsers = CSVHelper.GetSignedInUsers();
        }
    }
}
