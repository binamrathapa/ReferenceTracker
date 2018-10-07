using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTracker
{
    public class Helper
    {
        public bool CheckEmail(string email)
        {
            if (email.Contains("@"))
                return true;
            else
                return false;
        }
        public bool CheckPasswords(string password,string confirmPassword)
        {
            if (password.Equals(confirmPassword))
                return true;
            else
                return false;
        }
    }
}
