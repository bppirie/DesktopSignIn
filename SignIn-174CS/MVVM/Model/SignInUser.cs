using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_174CS.MVVM.Model
{
    internal class SignInUser
    {
        public SignInUser(string lastName)
        {
            LastName = LastName;
        }

        public bool IsCSL { get; set; }

        public string CSLName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Rank { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
