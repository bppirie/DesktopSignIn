using SignIn_174CS.Core;
using SignIn_174CS.Helpers;
using System.Linq;
using System.Security.Policy;

namespace SignIn_174CS.MVVM.ViewModel
{
    internal class SignInCSLViewModel : ObservableObject
    {
        public RelayCommand SignInCSLFalseCommand { get; set; }
        public RelayCommand SignInCSLTrueCommand { get; set; }
        public RelayCommand ClearCommand { get; set; }
        public RelayCommand SubmitCommand { get; set; }

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

            SubmitCommand = new RelayCommand(o =>
            {
                if (VerifySignInData())
                {
                    AddSignInEntry();
                }
            });
        }

        public SignInCSLViewModel(MainViewModel mainViewModel) : this()
        {
            _mainViewModel = mainViewModel;
        }

        /// <summary>
        /// Make sure that all the fields are filled in correctly
        /// </summary>
        private bool VerifySignInData()
        {
            // Verify Last Name
            if (string.IsNullOrEmpty(LastName) || LastName.Length > 100 || LastName.Any(c => char.IsNumber(c)))
            {
                return false;
            }

            // Verify Description
            if (string.IsNullOrEmpty(Description) || Description.Length > 500)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Add the data to the CSV file
        /// </summary>
        private void AddSignInEntry()
        {
            CSVHelper.AddToCSV(LastName, Description, isCSL: true);
        }
    }
}
