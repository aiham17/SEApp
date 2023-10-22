using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEApp
{
    public class userInfo
    {

        // This struct is the basis to store the encrypted user details to then be added to the CitisoftDB, UserInformation Table
        public struct userRegister
        {
            public int userID;
            public string userName;
            public string password;
            public string firstName;
            public string lastName;
            public string email;
            public int companyRole;
        }
        
    }
}
