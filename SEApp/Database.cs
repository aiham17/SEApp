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


        /* The updated code for the readUsername method improves the authentication logic by utilizing a SqlDataReader to directly read query results.
         * It checks for the existence of rows in the result, iterates through each row, 
         * and compares the provided username and password with the stored values in the database.
         * If a match is found, it immediately returns true for a successful login. 
         * This streamlined approach enhances clarity, efficiency, and error handling compared to the previous version, which used a DataTable and a more complex loop structure.  */
        public bool readUsername(string user, string pass)
        {
            EncryptDecrypt passVerify = new EncryptDecrypt();
            string readUser = sqlQuery.readUser;

            try
            {
                using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
                {
                    using (SqlCommand readUsername = new SqlCommand(readUser, connectDB))
                    {
                        readUsername.Parameters.AddWithValue("@user", user);
                        connectDB.Open();

                        using (SqlDataReader readUsers = readUsername.ExecuteReader())
                        {
                            if (readUsers.HasRows)
                            {
                                while (readUsers.Read())
                                {
                                    string storedUser = readUsers["Username"].ToString();
                                    string storedPass = readUsers["Password"].ToString();
                                    string storedSalt = readUsers["Salt"].ToString();

                                    if (user == storedUser && passVerify.passwordVerify(storedPass, storedSalt, pass))
                                    {
                                        return true; // Username and password match
                                    }
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Log or display the exception details
                MessageBox.Show($"An error occurred: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        public bool CheckUserExists(string username, string email)
        {
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                string checkUser = sqlQuery.checkUser;
                using (SqlCommand command = new SqlCommand(checkUser, connectDB))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        /* Implemented GetUserRole method in the  class to retrieve the role of a user from the database based on their username.
         * This functionality is utilized for role-based access control in the application, 
         * allowing certain features to be accessible only to users with specific roles. 
         * Updated Login and Settings forms to use this method for checking user roles.*/
        public string GetUserRole(string username)
        {
            string query = "SELECT CompanyRole FROM UserInformation WHERE Username = @username";

            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand command = new SqlCommand(query, connectDB))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@username", username);

                        object result = command.ExecuteScalar();

                        return result != null ? result.ToString() : null;
                    }
                    catch (Exception ex)
                    {
                        // Log or display the exception details
                        Console.WriteLine("Error in GetUserRole: " + ex.Message);
                        return null; // Return null or handle the error as needed
                    }
                }
            }
        }



        public DataTable getVendorProducts(string sqlQuery)
        {
            DataTable vendorProduct = ExecuteQuery(sqlQuery);

            return vendorProduct;


        }
    }
}

