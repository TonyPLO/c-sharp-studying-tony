using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.Account
{
    public class Owner
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }


        public Owner(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
