﻿using System;
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




    }
}