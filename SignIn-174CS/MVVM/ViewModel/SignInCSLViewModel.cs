using SignIn_174CS.Core;

namespace SignIn_174CS.MVVM.ViewModel
{
    internal class SignInCSLViewModel : ObservableObject
    {
        public RelayCommand SignInCSLFalseCommand { get; set; }
        public RelayCommand SignInCSLTrueCommand { get; set; }
        public RelayCommand ClearCommand { get; set; }

        private MainViewModel _mainViewModel;

        #region Fields

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

        private SignInCSLViewModel()
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
                LastName = "";
                Description = "";
            });
        }

        public SignInCSLViewModel(MainViewModel mainViewModel) : this()
        {
            _mainViewModel = mainViewModel;
        }
    }
}
