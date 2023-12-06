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
        // Removed the for loop as the SQL Query will
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
        /* Implemented SaveSupportTicket method to insert support ticket details into the database.
         * Utilized SqlConnection and SqlCommand for database interaction, including parameterized queries for ticket information. 
         * Incorporated robust error handling with a try-catch block to manage potential exceptions during execution. */
        public void SaveSupportTicket(string name, string email, string topic, string message, string userID)
        {
            try
            {
                List<string> parameterNames = new List<string> { "@userID", "@Name", "@Email", "@Topic", "@Message" };
                using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
                {
                    connectDB.Open();
                    if (userID != null)
                    {
                        using (SqlCommand saveTicket = new SqlCommand(sqlQuery.saveSupportTicket2, connectDB))
                        {
                            saveTicket.CommandType = CommandType.Text;
                            for (int i = 0; i < parameterNames.Count; i++)
                            {
                                saveTicket.Parameters.AddWithValue(parameterNames[i], i == 0 ? userID : (i == 1 ? name : (i == 2 ? email : (i == 3 ? topic : message))));
                            }
                            saveTicket.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        List<string> excludeUserIDParameters = new List<string> { "@Name", "@Email", "@Topic", "@Message" };
                        using (SqlCommand saveTicket = new SqlCommand(sqlQuery.saveSupportTicket, connectDB))
                        {
                            saveTicket.CommandType = CommandType.Text;
                            for (int i = 0; i < parameterNames.Count; i++)
                            {
                                saveTicket.Parameters.AddWithValue(parameterNames[i], i == 1 ? name : (i == 2 ? email : (i == 3 ? topic : message)));
                            }
                            saveTicket.ExecuteNonQuery();
                        }
                    }

                }
                //using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
                //{
                //using (SqlCommand saveTicket = new SqlCommand(sqlQuery.saveSupportTicket, connectDB))
                //{
                // saveTicket.Parameters.AddWithValue("@Name", name);
                //saveTicket.Parameters.AddWithValue("@Email", email);
                //saveTicket.Parameters.AddWithValue("@Topic", topic);
                //saveTicket.Parameters.AddWithValue("@Message", message);

                // connectDB.Open();
                // saveTicket.ExecuteNonQuery();
                //}
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the support ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
                //using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
                //{
                   // using (SqlCommand saveTicket = new SqlCommand(sqlQuery.saveSupportTicket, connectDB))
                   // {
                      //  saveTicket.Parameters.AddWithValue("@Name", name);
                       // saveTicket.Parameters.AddWithValue("@Email", email);
                       // saveTicket.Parameters.AddWithValue("@Topic", topic);
                       // saveTicket.Parameters.AddWithValue("@Message", message);

                       // connectDB.Open();
                       // saveTicket.ExecuteNonQuery();
                    //}
                //}
            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show($"An error occurred while saving the support ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

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

        

        /* The UpdateUserInfo method serves the purpose of updating user information in the database.
         * It is specifically designed to modify the records in the UserInformation table based on the provided UserID. 
         * It constructs an SQL query that updates the username, password, salt, and email for a user with a specific UserID.
         * The method establishes a connection to the database, creates a SqlCommand to execute the update query, and sets parameters with the provided values.
         * Finally, it executes the query to apply the modifications.*/
        public void UpdateUserInfo(int userID, string newUsername, string newPasswordHash, string newSalt, string newEmail)
        {
            // SQL query to update user information in the UserInformation table based on the provided UserID
            string updateQuery = "UPDATE UserInformation SET Username = @Username, Password = @Password, Salt = @Salt, Email = @Email WHERE UserID = @UserID";

            // Establish a connection to the database
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                // Open the database connection
                connectDB.Open();
                // Create a SqlCommand to execute the update query
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connectDB))
                {
                    // Set parameters for the update query with values provided as arguments
                    updateCommand.Parameters.AddWithValue("@UserID", userID);
                    updateCommand.Parameters.AddWithValue("@Username", newUsername);
                    updateCommand.Parameters.AddWithValue("@Password", newPasswordHash);
                    updateCommand.Parameters.AddWithValue("@Salt", newSalt);
                    updateCommand.Parameters.AddWithValue("@Email", newEmail);

                    // Execute the update query to modify user information in the database
                    updateCommand.ExecuteNonQuery();
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
            using (SqlConnection connectDB = new SqlConnection(dbConnectstr))
            {
                connectDB.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery.getUserRole, connectDB))
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


        //Adam:
        public DataTable getVendorProducts(string sqlQuery)
        {
            DataTable vendorProduct = ExecuteQuery(sqlQuery);
            return vendorProduct;
        }

        // Updates the vendor information according to what the admin has entered
        // Adjusted the parameters assigned to a list for loop as this looked better. This has been applied to all the updateVendor methods etc and addVendor methods etc
        // Adam
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

        // Updates the contact information of the specific vendor, according to what the admin has adjusted
        // Adam:
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

        // Updates the products information with what the admin has edited
        // Adam:
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

        //Adam:
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

        // Adam:
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
        
        //Adam:
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
                   
                }
            }
        }
      

        // Adam:
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
                }
            }
        }


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



