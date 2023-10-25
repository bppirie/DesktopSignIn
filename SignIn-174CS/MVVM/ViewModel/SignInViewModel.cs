using SignIn_174CS.Core;
using SignIn_174CS.Helpers;
using System.Linq;

namespace SignIn_174CS.MVVM.ViewModel
{
    internal class SignInViewModel : ObservableObject
    {
        public RelayCommand SignInCSLFalseCommand { get; set; }
        public RelayCommand SignInCSLTrueCommand { get; set; }
        public RelayCommand ClearCommand { get; set; }
        public RelayCommand SubmitCommand { get; set; }

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

        private SignInViewModel()
        {
            // Runs when user answers no to the CSL question
            SignInCSLFalseCommand = new RelayCommand(o =>
            {
                _mainViewModel.SetSignInCSL(false);
            });

            // Runs when user answers yes to the CSL question
            SignInCSLTrueCommand = new RelayCommand(o =>
            {
                _mainViewModel.SetSignInCSL(true);
            });

            // Runs when the clear button is clicked
            ClearCommand = new RelayCommand(o =>
            {
                CSLName = "";
                FirstName = "";
                LastName = "";
                Rank = "";
                Phone = "";
                Email = "";
                Description = "";
            });

            // Runs when the submit button is clicked
            SubmitCommand = new RelayCommand(o =>
            {
                if (VerifySignInData()) 
                {
                    AddSignInEntry();
                    _mainViewModel.UpdateSignOutRoster();
                    ClearCommand.Execute(null);
                }
            });
        }

        public SignInViewModel(MainViewModel mainViewModel) : this()
        {
            _mainViewModel = mainViewModel;
        }   

        /// <summary>
        /// Make sure that all the fields are filled in correctly
        /// </summary>
        private bool VerifySignInData()
        {
            // Verify CSL Name
            if (!string.IsNullOrEmpty(CSLName) && (CSLName.Length > 100 || CSLName.Any(c => char.IsNumber(c))))
            {
                return false;
            }

            // Verify First Name
            if (string.IsNullOrEmpty(FirstName) || FirstName.Length > 100 || FirstName.Any(c => char.IsNumber(c)))
            {
                return false;
            }

            // Verify Last Name
            if (string.IsNullOrEmpty(LastName) || LastName.Length > 100 || LastName.Any(c => char.IsNumber(c)))
            {
                return false;
            }

            // Verify Rank
            if (string.IsNullOrEmpty(Rank) || Rank.Length > 10 || !RankHelper.IsValidRank(Rank))
            {
                return false;
            }

            // Verify Phone
            if (string.IsNullOrEmpty(Phone) || Phone.Length > 15 || Phone.Length < 4 || Phone.Any(c => !char.IsNumber(c) && !char.Equals('-', c) && !char.Equals('+', c)))
            {
                return false;
            }

            // Verify Email
            if (string.IsNullOrEmpty(Email) || Email.Length > 100 || Email.Length < 5 || !Email.Contains('@') || !Email.Contains('.'))
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
            CSVHelper.AddToCSV(LastName, Description, cslName: CSLName, firstName: FirstName, rank: Rank, phone: Phone, email: Email);
        }
    }
}
