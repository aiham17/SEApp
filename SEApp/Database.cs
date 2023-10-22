using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SEApp
{
    class Database
    {
        private static Database dbGetString;

        private string dbConnectstr;

        // Initialises dbConnectstr to the DBConnectionString (stores it)
        private Database()
        {
            dbConnectstr = Properties.Settings.Default.DBConnectionString;
        }

        // Get Access to DB (Run the method to get connection string)
        public static Database getConnectString()
        {
            if (dbGetString == null)
            {
                dbGetString = new Database(); 
            }
            return dbGetString;
        }


        // Saves UserInfo inputted in the registration form to the Database
        // NEED TO LOOK INTO PASSING A STRUCT AS THE PARAMETER RATHER THAN INDIVDUAL VARIABLES
        
        public void saveUserInfo(string SQLQuery, string userName, string password, string firstName, string lastName, string email, int CompanyRole)
        {
            //Store the columns of the DB. Will be creating one for the variables and gonna try a for loop.
            List<string> columns = new List<string>{"Username", "Password", "FirstName", "LastName", "Email", "CompanyRole"};
            
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                SqlCommand addUser = new SqlCommand(SQLQuery, connectDB);

                addUser.CommandType = CommandType.Text;
                addUser.Parameters.Add(SQLQuery);
                addUser.ExecuteNonQuery();

            }

            


        }
    }
}
