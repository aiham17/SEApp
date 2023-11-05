using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.CodeDom.Compiler;
using System.Collections;
using SEApp.CitisoftDBDataSetTableAdapters;


namespace SEApp
{
    class Database
    {
        private static Database dbGetString;
        private string dbConnectstr;


        // Constructor initializes dbConnectstr to the DBConnectionString (stores it)
        // Source Videos on Canvas: Software Engineering
        private Database()
        {
            dbConnectstr = Properties.Settings.Default.DBConnectionString;
        }

        // Get access to DB (Run the method to get connection string)
        // Source Videos on Canvas: Software Engineering
        public static Database getConnectString()
        {
            if (dbGetString == null)
            {
                dbGetString = new Database();
            }
            return dbGetString;
        }


        public bool CheckUserExists(string username, string email)
        {
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserInformation WHERE Username=@username OR Email=@email", connectDB))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }


        // Fixed issue in saveUserInfo method
        // In the saveUserInfo method, replaced the line `addUser.Parameters.Add(SQLQuery);`
        // with individual parameter additions using `addUser.Parameters.AddWithValue()` to correctly bind parameters for the SQL query execution.
        // This ensures that user information is properly saved to the database.


        public void saveUserInfo(string SQLQuery, string userName, string password, string salt, string firstName, string lastName, string email, int CompanyRole)
        {
            List<string> parameterNames = new List<string> { "@Username", "@Password", "@Salt", "@FirstName", "@LastName", "@Email", "@CompanyRole" };
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                SqlCommand addUser = new SqlCommand(SQLQuery, connectDB);

                addUser.CommandType = CommandType.Text;

                // Loop through parameter names and add them to the command with their corresponding values
                for (int i = 0; i < parameterNames.Count; i++)
                {
                    addUser.Parameters.AddWithValue(parameterNames[i], i == 0 ? userName : (i == 1 ? password : (i == 2 ? salt : (i == 3 ? firstName : (i == 4 ? lastName : (i == 5 ? email : CompanyRole))))));
                }

                addUser.ExecuteNonQuery();
            }
            
        }

        //Adam:
        /* Reads the Database for a username match, then gets the password and the salt code that corresponds to it
         * https://stackoverflow.com/questions/565425/how-can-i-get-a-username-and-password-from-my-database-in-c
         * Post by: Abel Gaxiola Feb 2009 with understanding how to read results into a Data Table
         * Post by: Geochet for understanding how to read from database.
         */
        public bool readUsername(string user, string pass)
        {
            EncryptDecrypt passVerify = new EncryptDecrypt();
            string readUser = sqlQuery.readUser;

            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                bool readPassword;
                
                using (SqlCommand readUsername = new SqlCommand(readUser, connectDB))
                {

                    readUsername.Parameters.AddWithValue("@user", user);
                    connectDB.Open();
                    SqlDataReader readUsers = readUsername.ExecuteReader();
                    DataTable readResult = new DataTable();
                    readResult.Load(readUsers);
                    string place, testUser, testPass, testSalt;

                    int i;
                    for (i = 0; i < readResult.Rows.Count; i++)
                    {
                        place = readResult.Rows[i].Field<string>("Username").ToString();
                        if (place == user)
                        {

                            break;

                        }
                        else if (i >= readResult.Rows.Count)
                        {
                            MessageBox.Show("The Username & Password entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }


                    }
                    i = i - 1;
                    if (i < 0)
                    {
                        MessageBox.Show("The Username & Password entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    place = readResult.Rows[i].Field<string>("Username").ToString();
                    testUser = place;
                    testPass = readResult.Rows[i].Field<string>("Password").ToString();
                    testSalt = readResult.Rows[i].Field<string>("Salt").ToString();
                    return readPassword = passVerify.passwordVerify(testPass, testSalt, pass);






                }



            }

        }


        // The ExecuteQuery method in the Database class streamlines database interactions.
        // It executes SQL queries and presents results as DataTables, simplifying database operations.
        // It Utilized in the dashboard form to perform database queries when buttons are clicked, such as retrieving total vendor count.
        public DataTable ExecuteQuery(string sqlQuery)
        {
            DataTable result = new DataTable();
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connectDB))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
            }
            return result;

        }


        public DataTable getVendorProducts()
        {
            DataTable vendorProduct = ExecuteQuery(sqlQuery.getVendorProductData);

            return vendorProduct;


        }
    }
}

