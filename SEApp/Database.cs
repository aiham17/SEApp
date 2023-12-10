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
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Asn1.Cms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using iTextSharp.text.pdf.parser;
using static Org.BouncyCastle.Crypto.Digests.SkeinEngine;


namespace SEApp
{
    class Database
    {
        // Stores the connection string and used to create an instance to the Database
        private static Database dbGetString;
        private string dbConnectstr;

        //Adam:
        // Constructor initializes dbConnectstr to the DBConnectionString (stores it)
        // Source Videos on Canvas: Software Engineering
        private Database()
        {
            dbConnectstr = Properties.Settings.Default.DBConnectionString;
        }

        // Adam:
        // Get access to DB (Run the method to get connection string)
        // Source Lecture Videos on Canvas: Software Engineering in Week 5
        public static Database getConnectString()
        {
            if (dbGetString == null)
            {
                dbGetString = new Database();
            }
            return dbGetString;
        }
         
        // Aiham coded the following database methods for the Registration, Dashboard, Login&Security, Support, and Setting Forms: 

        // Aiham:

        /* This saveUserInfo method takes in user information and inserts it into the database using a parameterized SQL query .
         * It creates a connection to the database, prepares an SQL command, adds parameters to the command, 
         * and executes it to save user information table in the database.*/
        public void saveUserInfo(string SQLQuery, string userName, string password, string salt, string firstName, string lastName, string email, int CompanyRole)
        {
            // List of parameter names to be used in the SQL command
            List<string> parameterNames = new List<string> { "@Username", "@Password", "@Salt", "@FirstName", "@LastName", "@Email", "@CompanyRole" };

            // Establish a connection to the database
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();

                // Create a SQL command
                SqlCommand addUser = new SqlCommand(SQLQuery, connectDB);
                addUser.CommandType = CommandType.Text;

                // Loop through parameter names and add them to the command with their corresponding values
                for (int i = 0; i < parameterNames.Count; i++)
                {
                    // Add parameters to the SQL command
                    addUser.Parameters.AddWithValue(parameterNames[i], i == 0 ? userName : (i == 1 ? password : (i == 2 ? salt : (i == 3 ? firstName : (i == 4 ? lastName : (i == 5 ? email : CompanyRole))))));
                }

                // Execute the SQL command (inserting user information into the database)
                addUser.ExecuteNonQuery();
            }
        }

        // Aiham:

        /* This method takes support ticket information as parameters and saves it to the database using a parameterized SQL query.
         * It handles exceptions and displays an error message if there is any issue during the database operation.
        
         * Using DBNull.Value to Handle Null or Empty User IDs When Saving Support Tickets to a Database 
         * From: https://learn.microsoft.com/en-us/dotnet/api/system.dbnull?view=net-8.0 
         * From: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlparametercollection.addwithvalue?view=dotnet-plat-ext-8.0 */

        public void SaveSupportTicket(string name, string email, string title, string message, string userID)
        {
            try
            {
                // Establish a connection to the database using the connection string
                using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
                {
                    // Open the database connection
                    connectDB.Open();

                    // Define a SQL command to save a support ticket
                    using (SqlCommand saveTicket = new SqlCommand(sqlQuery.SaveSupportTicket, connectDB))
                    {
                        // Add a SQL parameter for UserID with the name "@UserID".
                        // If userID is not null or empty, set the parameter value to userID;
                        // otherwise, set it to DBNull.Value to indicate a null database value.
                        saveTicket.Parameters.AddWithValue("@UserID", !string.IsNullOrEmpty(userID) ? userID : (object)DBNull.Value);

                        // Define parameter names and corresponding values
                        string[] parameterNames = { "@Name", "@Email", "@Title", "@Message" };
                        string[] parameterValues = { name, email, title, message };

                        // Add parameters using a loop
                        for (int i = 0; i < parameterNames.Length; i++)
                        {
                            saveTicket.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                        }

                        // Execute the SQL command to insert the support ticket into the database
                        saveTicket.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs while saving the support ticket
                MessageBox.Show($"An error occurred while saving the support ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Aiham:

        /* The UpdateUserInfo method serves the purpose of updating user information in the database.
         * It is specifically designed to modify the records in the UserInformation table based on the provided UserID. 
         * It constructs an SQL query that updates the username, password, salt, and email for a user with a specific UserID.
         * The method establishes a connection to the database, creates a SqlCommand to execute the update query, and sets parameters with the provided values.
         * Finally, it executes the query to apply the modifications.*/
        public void UpdateUserInfo(int userID, string newUsername, string newPasswordHash, string newSalt, string newEmail)
        {
            // Establish a connection to the database
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                // Open the database connection
                connectDB.Open();
                // Create a SqlCommand to execute the update query
                using (SqlCommand updateCommand = new SqlCommand(sqlQuery.UpdateUserInfoQuery, connectDB))
                {
                    // Set parameters for the update query with values provided as arguments using a loop
                    updateCommand.Parameters.AddWithValue("@UserID", userID);

                    // Define an array of parameter names to loop through
                    string[] parameterNames = { "@Username", "@Password", "@Salt", "@Email" };
                    string[] parameterValues = { newUsername, newPasswordHash, newSalt, newEmail };

                    for (int i = 0; i < parameterNames.Length; i++)
                    {
                        updateCommand.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                    }

                    // Execute the update query to modify user information in the database
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        // Aiham:

        /* This ExecuteQuery method allows executing SQL queries against a database and retrieves the results of a SQL query into a DataTable,
         * The DataTable is then used to populate charts in the Dashboard form, providing a visual representation of the queried data.*/
        public DataTable ExecuteQuery(string sqlQuery)
        {
            // Create a new DataTable to store the results of the SQL query
            DataTable result = new DataTable();

            // Create a new SqlConnection using the connection string stored in dbConnectstr
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                // Open the database connection
                connectDB.Open();

                // Create a new SqlCommand with the provided SQL query and the open connection
                using (SqlCommand command = new SqlCommand(sqlQuery, connectDB))
                {
                    // Execute the SQL query and obtain a SqlDataReader to read the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Load the results from the SqlDataReader into the DataTable
                        result.Load(reader);
                    }
                }
            }

            // Return the filled DataTable containing the results of the SQL query
            return result;
        }


        // Aiham

        // This CheckUserExists method checks whether a user with a given username or email already exists in the database.

        public bool CheckUserExists(string username, string email)
        {
            // Create a new SqlConnection using the connection string from the class's field
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                // Open the database connection
                connectDB.Open();

                // Get the SQL query for checking user existence from the sqlQuery class
                string checkUser = sqlQuery.CheckUser;

                // Create a new SqlCommand with the checkUser query and the open SqlConnection
                using (SqlCommand command = new SqlCommand(checkUser, connectDB))
                {
                    // Set the parameters for the query to the provided username and email values
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);

                    // Execute the query and retrieve the count of matching rows (users)
                    int count = (int)command.ExecuteScalar();

                    // Return true if the count is greater than 0, indicating that the user exists; otherwise, return false
                    return count > 0;
                }
            }
        }

        //Aiham

        /* Implemented GetUserRole method in the Databbase class to retrieve the role of a user from the database based on their username.
         * This functionality is utilized for role-based access control in the application, 
         * allowing certain features to be accessible only to users with specific roles. 
         * Updated Login and Settings forms to use this method for checking user roles.*/
        
        public string GetUserRole(string username)
        {
            // Establish a connection to the database
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                // Open the database connection
                connectDB.Open();
               // Create a SQL command using the GetUserRole query and the database connection
                using (SqlCommand command = new SqlCommand(sqlQuery.GetUserRole, connectDB))
                {
                    try
                    {
                        // Add a parameter for the username to the SQL command
                        command.Parameters.AddWithValue("@username", username);

                        // Execute the SQL command and retrieve the result
                        object result = command.ExecuteScalar();
                        // Return the result as a string, or null if the result is null
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
            try
            {
                using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
                {
                    using (SqlCommand readUsername = new SqlCommand(readUser, connectDB))
                    {
                        readUsername.Parameters.AddWithValue("@user", user);
                        connectDB.Open();
                        SqlDataReader readUsers = readUsername.ExecuteReader();
                        DataTable readResult = new DataTable();
                        readResult.Load(readUsers);
                        string storedUser, storedPass, storedSalt;
                        if (readResult.Rows.Count > 0)
                        {
                            storedUser = readResult.Rows[0].Field<string>("Username").ToString();
                            storedPass = readResult.Rows[0].Field<string>("Password").ToString();
                            storedSalt = readResult.Rows[0].Field<string>("Salt").ToString();
                            return passVerify.passwordVerify(storedPass, storedSalt, pass);
                        }
                        else
                        {
                            MessageBox.Show("The Username & Password entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        



        //Adam:
        // Gets the vendor and product names to then pass to readVendorProductInfo and select which SQL Query should be passed.
        // Will return either a filled DataTable or a null one
        public DataTable getVendorProductInfo(string vendorName, string productName)
        {
            try
            {
                DataTable readData = new DataTable();
                if (vendorName != null && productName != null)
                {
                    readData = readVendorProductInfo(readData, vendorName, productName, sqlQuery.loadVendor);
                    return readData;
                }
                else if (vendorName != null && productName == null)
                {
                    readData = readVendorProductInfo(readData, vendorName, productName, sqlQuery.loadVendor2);
                    return readData;
                }

                else
                {
                    readData = readVendorProductInfo(readData, vendorName, productName, sqlQuery.loadVendor3);
                    return readData;
                }    
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred");
                return null;
            }
        }


        //Adam:
        // Opens a connection to the database and will run a SQL Query dependant upon the values of vendorName and productName to then return the datatable filled or not
        public DataTable readVendorProductInfo(DataTable readData,string vendorName, string productName, string sqlQuery)
        {
            try
            {
                using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
                {
                    using (SqlCommand getData = new SqlCommand(sqlQuery, connectDB))
                    {
                        if (vendorName != null && productName != null)
                        {
                            getData.Parameters.Add("@company", vendorName);
                            getData.Parameters.Add("@software", productName);
                            connectDB.Open();
                            SqlDataReader getDataVP = getData.ExecuteReader();

                            readData.Load(getDataVP);
                            return readData;
                        }
                        else if (vendorName != null && productName == null)
                        {
                            getData.Parameters.Add("@company", vendorName);
                            connectDB.Open();
                            SqlDataReader getDataVP = getData.ExecuteReader();

                            readData.Load(getDataVP);
                            return readData;
                        }
                        else {
                            getData.Parameters.Add("@software", productName);
                            connectDB.Open();
                            SqlDataReader getDataVP = getData.ExecuteReader();
                            readData.Load(getDataVP);
                            return readData;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        //Adam:
        // Opens a connection to the database and reads all the contact information associated with the vendor selected and stores it in the datatable.
        // This datatable is then returned.
        public DataTable readVendorContact(DataTable contactData, int vendorID)
        {
            try
            {
                using(SqlConnection connectDB = new SqlConnection(dbConnectstr))
                {
                    using(SqlCommand getContact = new SqlCommand(sqlQuery.loadContact, connectDB))
                    {
                        getContact.Parameters.Add("@VendorID", vendorID);
                        connectDB.Open();
                        SqlDataReader getContactVP = getContact.ExecuteReader();
                        contactData.Load(getContactVP);
                        return contactData;

                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        //Adam: A Universal Method used to execute select queries for each filter applied in the VendorProducts Form. Returns a datatable as the result
        public DataTable getVendorProducts(string sqlQuery)
        {
            DataTable vendorProduct = ExecuteQuery(sqlQuery);
            return vendorProduct;
        }


        // Adam: Updates the vendor information according to what the admin has entered
        // Adjusted the parameters assigned to a list for loop as this looked better. This has been applied to all the updateVendor methods etc and addVendor methods etc
        public void updateVendor(string vendor, string website, string description, string additionalInfo, string employees, string eYear, string reviewDate, string DemoDate,  int intPro, int vendorID)
        {
            List<string> parameterNames = new List<string> { "@vendor", "@web", "@description", "@eyear", "@employ", "@lreview", "@ldemo", "@addInfo", "@intProService", "@vendorID" };
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery.updateVendor, connectDB))
                {
                    command.CommandType = CommandType.Text;
                    for (int i = 0; i < parameterNames.Count; i++)
                    {
                        command.Parameters.AddWithValue(parameterNames[i], i == 0 ? vendor : (i == 1 ? website : (i == 2 ? description : (i == 3 ? eYear : (i == 4 ? employees : (i == 5 ? reviewDate : (i == 6 ? DemoDate : (i == 7 ? additionalInfo : (i==8 ? intPro :vendorID)))))))));
                    }
                   
                    command.ExecuteNonQuery();
                }
                
            }
           
        }

        // Adam: Updates the contact information of the specific vendor, according to what the admin has adjusted
        public void updateContact(string address, string teleNumber, int contactID)
        {
            List<string> parameterNames = new List<string> {"@number", "@address", "@contactID"};
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand updateContact = new SqlCommand(sqlQuery.updateContact, connectDB))
                {
                    updateContact.CommandType = CommandType.Text;
                    for (int i = 0; i < parameterNames.Count; i++)
                    {
                        updateContact.Parameters.AddWithValue(parameterNames[i], i == 0 ? teleNumber : (i == 1 ? address : contactID));
                    }
                    
                    updateContact.ExecuteNonQuery();
                }
            }
        }

        // Adam: Updates the products information with what the admin has edited
        public void updateProduct(string software, string softwareType, string businessArea, string module, string financialService, string cloud, int productID)
        {
            List<string> parameterNames = new List<string> {"@software", "@type", "@area", "@module", "@fsc", "@cloud", "@productID"};
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand updateProduct = new SqlCommand(sqlQuery.updateProduct, connectDB))
                {
                    updateProduct.CommandType = CommandType.Text;
                    for (int i = 0; i < parameterNames.Count; i++)
                    {
                        updateProduct.Parameters.AddWithValue(parameterNames[i], i == 0 ? software : (i == 1 ? softwareType : (i == 2 ? businessArea : (i == 3 ? module : (i == 4 ? financialService : (i == 5 ? cloud : productID))))));
                    }
                   
                    updateProduct.ExecuteNonQuery();
                }
            }
        }

        //Adam: Deletes the Vendor and all of its products from the Database.
        public void deleteVendorProduct(int vendor)
        {
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand deleteVendor = new SqlCommand(sqlQuery.deleteVendor, connectDB))
                {
                    deleteVendor.Parameters.AddWithValue("@vendor", vendor);
                    deleteVendor.ExecuteNonQuery();
                }
                
            }
        }

        //Adam: Deletes the specific product, selected by the user, from the database
        public void deleteProduct(int productID)
        {
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand deleteProduct = new SqlCommand(sqlQuery.deleteProduct, connectDB))
                {
                    deleteProduct.Parameters.AddWithValue("@product", productID);
                    deleteProduct.ExecuteNonQuery();
                }

            }
        }

        //Adam:
        // This method grabs the PDF Documents Name corresponding to the vendor and product ids passed to the method. 
        // The file name is stored in the Documents table and then this file name is returned if it is found otherwise it returns null
        public string getPdfName(int vendorID, int productID)
        {
            string fileName;
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand getPath = new SqlCommand(sqlQuery.getPDFPath, connectDB))
                {
                    getPath.Parameters.AddWithValue("@vendor", vendorID);
                    getPath.Parameters.AddWithValue("@product", productID);
                    SqlDataReader reader = getPath.ExecuteReader();
                    if (reader.Read())
                    {
                        fileName = reader.GetString(0);
                        return fileName;
                    }
                    else
                    {
                        return null;
                    }
                }

            }
            
            
        }

        // Adam: Adds a Vendor to the Database table VendorInfo
        public int addVendor(string vendor, string website, string description, string additionalInfo, string employees, string eYear, string reviewDate, string DemoDate, int intPro)
        {
            List<string> parameterNames = new List<string> { "@vendor", "@web", "@description", "@eyear", "@employ", "@lreview", "@ldemo", "@addInfo", "@intProService" };
            using(SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using(SqlCommand addVendor = new SqlCommand(sqlQuery.addVendor, connectDB))
                {
                    addVendor.CommandType = CommandType.Text;
                    for(int i = 0; i < parameterNames.Count; i++)
                    {
                        addVendor.Parameters.AddWithValue(parameterNames[i], i == 0 ? vendor : (i == 1 ? website : (i == 2 ? description : (i == 3 ? eYear : (i == 4 ? employees : (i == 5 ? reviewDate : (i == 6 ? DemoDate : (i == 7 ? additionalInfo : intPro))))))));
                    }
                    
                    int vendorID = Convert.ToInt32(addVendor.ExecuteScalar());
                    return vendorID;
                }
            }
        }

        //Adam:  Adds a Product to the Database Table ProductInfo
        public void addProduct(string software, string softwareType, string businessArea, string module, string financialService, string cloud, int vendor)
        {
            List<string> parameterNames = new List<string> { "@vendor", "@software", "@type", "@area", "@module", "@fsc", "@cloud"};
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand addProduct = new SqlCommand(sqlQuery.addProduct, connectDB))
                {
                    addProduct.CommandType = CommandType.Text;
                    for (int i = 0; i < parameterNames.Count; i++)
                    {
                        addProduct.Parameters.AddWithValue(parameterNames[i], i == 0 ? vendor : (i == 1 ? software : (i == 2 ? softwareType : (i == 3 ? businessArea : (i == 4 ? module : (i == 5 ? financialService : cloud))))));
                    }
                    addProduct.ExecuteNonQuery();

                }
            }
        }


        // Adam: Adds the contact information, of the vendor, to the Database table Contact
        public void addContact(string address, string teleNumber, int vendor)
        {
            List<string> parameterNames = new List<string> { "@vendor", "@number", "@address"};
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand addContact = new SqlCommand(sqlQuery.addContact, connectDB))
                {
                    addContact.CommandType = CommandType.Text;
                    for (int i = 0; i < parameterNames.Count; i++)
                    {
                        addContact.Parameters.AddWithValue(parameterNames[i], i == 0 ? vendor : (i == 1 ? teleNumber : address));
                    }
                    addContact.ExecuteNonQuery();
                }
            }
        }

        //Adam: Used to get the UserID the user is logged in with (For the Support Form)
        public int getUserID(string email)
        {
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand getUserID = new SqlCommand(sqlQuery.getUserID, connectDB))
                {
                    try
                    {
                        getUserID.Parameters.AddWithValue("@email", email);
                        int userID = Convert.ToInt32(getUserID.ExecuteScalar());
                        return userID;



                    }
                    catch (Exception ex)
                    {

                        return 0;
                    }
                }
            }
        }
    }
}



