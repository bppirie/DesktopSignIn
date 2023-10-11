using SignIn_174CS.Core;

namespace SignIn_174CS.MVVM.ViewModel
{
    internal class SignInViewModel : ObservableObject
    {
        public RelayCommand SignInCSLFalseCommand { get; set; }
        public RelayCommand SignInCSLTrueCommand { get; set; }
        public RelayCommand ClearCommand { get; set; }

        private MainViewModel _mainViewModel;

        #region Fields

        private string _cslName;
        public string CSLName
        {
            get { return _cslName; }
            set
            {
                _cslName = value;
                OnPropertyChanged();
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        private string _rank;
        public string Rank
        {
            get { return _rank; }
            set
            {
                _rank = value;
                OnPropertyChanged();
            }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public SignInViewModel()
        {
            SignInCSLFalseCommand = new RelayCommand(o =>
            {
                _mainViewModel.SetSignInCSL(false);
            });

            SignInCSLTrueCommand = new RelayCommand(o =>
            {
                _mainViewModel.SetSignInCSL(true);
            });

            ClearCommand = new RelayCommand(o =>
            {
                CSLName = "";
                FirstName = "";
                LastName = "";
                Rank = "";
                Phone = "";
                Email = "";
                Description = "";
                _mainViewModel.ClearSignIn();
            });
        }

        public SignInViewModel(MainViewModel mainViewModel) : this()
        {
            _mainViewModel = mainViewModel;
        }   
    }
}
