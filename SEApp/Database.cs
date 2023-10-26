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
        private Database()
        {
            dbConnectstr = Properties.Settings.Default.DBConnectionString;
        }

        // Get access to DB (Run the method to get connection string)
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
            // Display a message box indicating successful registration

            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Reads the Database for a username match, then gets the password and the salt code from the same row
        public void readUsername(string user, string pass)
        {
            using(SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                using (SqlCommand readUsername = new SqlCommand("SELECT * FROM UserInformation WHERE Username=@user AND Password=HASHBYTES('SHA1',@password)", connectDB))
                {
                    readUsername.Parameters.AddWithValue("@user", user);
                    readUsername.Parameters.AddWithValue("@password", pass);
                    connectDB.Open();
                    DataSet loginData = new DataSet();
                    // Trying to find a way to see if the username and hashed password is stored in this data set :)
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter = new SqlDataAdapter(readUsername);
                    dataAdapter.Fill(loginData,"user");
                    

                    

                }
            }
            

            //using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            //{
                //string readUserInfo = ("SELECT * FROM UserInformation WHERE Username =@user");
                //SqlCommand command = new SqlCommand(readUserInfo, connectDB);

                //command.Parameters.Add("@user",SqlDbType.VarChar).Value = user;
                //command.Parameters.Add("pass", SqlDbType.NVarChar).Value = pass;

                //DataSet loginData = new DataSet();
                //SqlDataAdapter dataAdapter;
                //connectDB.Open();
                //dataAdapter = new SqlDataAdapter(command);
                //dataAdapter.Fill(loginData);
                //MessageBox.Show(loginData.ToString());


                //https://stackoverflow.com/questions/28928543/compare-a-string-with-column-values-in-a-tablehttps://stackoverflow.com/questions/28928543/compare-a-string-with-column-values-in-a-table
                //connectDB.Open();
                //SqlCommand readUsername = new SqlCommand(sqlQuery, connectDB);
                //SqlParameter userRead = readUsername.Parameters.AddWithValue("@User", user);

                //readUsername.ExecuteNonQuery();
                // NEED TO GET VALUES BROUGHT UP BY THE SQL COMMAND: USERNAME, PASSWORD AND SALT
                // THEN HAVE TO DECRYPT THE VALUES

            //}
        }



    }
}
