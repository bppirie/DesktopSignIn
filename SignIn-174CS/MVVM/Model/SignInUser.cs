using SignIn_174CS.Core;
using SignIn_174CS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_174CS.MVVM.Model
{
    internal class SignInUser
    {
        public SignInUser( string cslName, string firstName, string lastName, string rank, string description, string email, string timeIn, string timeOut, string guid, bool isCSL, bool light = false)
        {
            Light = light;
            IsCSL = isCSL;
            CSLName = cslName;
            FirstName = firstName;
            LastName = lastName;
            Rank = rank;
            Description = description;
            Email = email;
            TimeIn = timeIn;
            TimeOut = timeOut;
            Guid = guid;

            /*SignOutUser = new RelayCommand(o =>
            {
                CSVHelper.UpdateCSV(Guid, TimeIn, LastName);
            });*/
        }

        public bool Light { get; set; }

        public string BackgroundColor
        {
            get
            {
                if (Light)
                {
                    return "#353340";
                }
                else
                {
                    return "Transparent";
                }
            }
        }

        //public RelayCommand SignOutUser { get; set; }

        public bool IsCSL { get; set; }

        public string CSLName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Rank { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string TimeIn { get; set; }

        public string TimeOut { get; set; }
        
        public string Guid { get; set; }
    }
}
