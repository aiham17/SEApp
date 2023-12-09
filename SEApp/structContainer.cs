using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEApp
{
    /* Created a new class named StructContainer to serve as a container for user, company, and support ticket structs. 
     * This class provides a centralized location for managing and accessing data related to users, companies, and support tickets.
     */
    public class structContainer
    {
        //Aiham
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
            public string salt; // Add this line for the salt
        }

        //Adam:
        // Stores the login details the user enters and 
        public struct login
        {
            public string username;
            public string password;
            
        }
        
        public class companyInfo
        {
            //Connor
            public struct vendorInfo
            {
                public string vendor;
                public string website;
                public string description;
                public string additionalInfo;
                public string address;
                public string teleNumber;
                public string employees;
                public string eYear;
                public string reviewDate;
                public string demoDate;
                public int intPro;
                public string software;
                public string softwareType;
                public string businessArea;
                public string module;
                public string financialService;
                public string cloud;

            }
        }

        //Aiham
        public class supportTicket
        {
            public struct Ticket
            {
                public int UserID;
                public string Name;
                public string Email;
                public string Title;
                public string Message;
            }
        }

    }
}
