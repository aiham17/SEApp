using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEApp
{
    // Created sqlQuery methods and setting the value for the first three queries.

    internal class sqlQuery
    {
        public const string readUser = "SELECT * FROM UserInformation WHERE Username=@user";
        public const string addUser = "INSERT INTO UserInformation (Username, Password, Salt, FirstName, LastName, Email, CompanyRole) VALUES (@Username, @Password, @Salt, @FirstName, @LastName, @Email, @CompanyRole)";
        public const string checkUser = "SELECT COUNT(*) FROM UserInformation WHERE Username=@username OR Email=@email";
        // Query to get total number of vendors
        public const string TotalNumberOfVendorsQuery = "SELECT COUNT(*) AS TotalVendors FROM VendorInfo";

        public const string getUserRole = "SELECT CompanyRole FROM UserInformation WHERE Username = @username";


        // Query to get active vendors
        public const string ActiveVendorsQuery = "SELECT TOP 5 Company_Name, * FROM VendorInfo WHERE Last_Reviewed >= DATEADD(month, -6, GETDATE()) AND YEAR(Last_Reviewed) = YEAR(GETDATE()) ORDER BY Last_Reviewed DESC"; // the LastReviewedDate should be in datetime format.

        // Query to get highest performing vendors
        public const string HighestPerformingVendorsQuery = "SELECT TOP 3 v.Company_Name,(SELECT COUNT(*) FROM ProductInfo p WHERE p.VendorID = v.VendorID) AS TotalProducts FROM VendorInfo v ORDER BY TotalProducts DESC";

        // Query to get lowest performing vendors
        public const string LowestPerformingVendorsQuery = "SELECT TOP 5 v.Company_Name,(SELECT COUNT(*) FROM ProductInfo p WHERE p.VendorID = v.VendorID) AS TotalProducts FROM VendorInfo v ORDER BY TotalProducts ASC";

        // Query to get Highest Rated products
        public const string HighestPerformingProductsQuery = "SELECT TOP 5 p.Software_Name, AVG(r.Rating) AS OverallRating FROM ProductInfo p JOIN Review r ON p.ProductID = r.ProductID GROUP BY p.Software_Name ORDER BY OverallRating DESC";

        // Query to get Lowest Rated products
        public const string LowestPerformingProductsQuery = "SELECT TOP 5 p.Software_Name , MIN(r.Rating) AS LowestRating FROM ProductInfo p JOIN Review r ON p.ProductID = r.ProductID GROUP BY p.Software_Name ORDER BY LowestRating ";

        // SELECT TOP 5 VendorID, AVG(Rating) AS AverageRating FROM Review GROUP BY VendorID Order BY AverageRating ASC
        // SELECT TOP 3 ProductInfo.Software_Name, (SELECT COUNT(*) FROM ProductInfo p WHERE p.ProductID=v.ProductID) AS AverageRating FROM Review  GROUP BY ProductID Order BY AverageRating ASC
        // Query to get highest performing market sectors
        public const string HighestPerformingMarketSectorsQuery = "";

        // Query to get lowest performing market sectors
        public const string LowestPerformingMarketSectorsQuery = "";

        // Query to get number of requests
        public const string NumberOfRequestsQuery = "";



        /* All of the SQL Queries below are for the Vendor Products Page.
         */
        // Gets all the vendor and product data from their respective tables
        public const string getVendorProductData = "SELECT * FROM VendorInfo RIGHT JOIN ProductInfo ON VendorInfo.VendorID = ProductInfo.VendorID ORDER BY VendorInfo.VendorID ";

        // Only grabs the vendor data that have been reviewed in the last 6 months
        public const string activeVendorData = "SELECT Company_Name, * FROM VendorInfo WHERE Last_Reviewed >= DATEADD(month, -6, GETDATE()) AND YEAR(Last_Reviewed) = YEAR(GETDATE()) ORDER BY VendorID";

        // Need to look into adding company name into this sql query also
        // Gets the average ratings for all the products with reviews
        public const string vendorProRatings = "SELECT p.Software_Name, AVG(r.Rating) AS Average_Rating FROM ProductInfo p JOIN Review r ON p.ProductID = r.ProductID  GROUP BY p.Software_Name ORDER BY Average_Rating DESC";

        // Gets all the vendor data
        public const string allVendors = "SELECT * FROM VendorInfo";

        // Gets all the Product data
        public const string allProducts = "SELECT * FROM ProductInfo";

        // All of these get the company and software names based on what cloud service they offer
        public const string basedCloud = "SELECT Company_Name, Software_Name, Cloud_Service_Type FROM VendorInfo JOIN ProductInfo ON VendorInfo.VendorID = ProductInfo.VendorID WHERE Cloud_Service_Type='Based'";
        public const string nativeCloud = "SELECT Company_Name, Software_Name, Cloud_Service_Type FROM VendorInfo JOIN ProductInfo ON VendorInfo.VendorID = ProductInfo.VendorID WHERE Cloud_Service_Type='Native'";
        public const string enabledCloud = "SELECT Company_Name, Software_Name, Cloud_Service_Type FROM VendorInfo JOIN ProductInfo ON VendorInfo.VendorID = ProductInfo.VendorID WHERE Cloud_Service_Type='Enabled'";
        public const string noCloud = "SELECT Company_Name, Software_Name, Cloud_Service_Type FROM VendorInfo JOIN ProductInfo ON VendorInfo.VendorID = ProductInfo.VendorID WHERE Cloud_Service_Type IS NULL";

        // Gets all of the Vendors Contact Information
        
        public const string allContact = "SELECT VendorInfo.Company_Name,Contact.Telephone_Numbers, Contact.Addresses FROM VendorInfo  JOIN Contact  on VendorInfo.VendorID = Contact.VendorID ORDER BY Contact.ContactID";
        public const string activeContact = "SELECT VendorInfo.Company_Name,Contact.Telephone_Numbers, Contact.Addresses FROM VendorInfo  JOIN Contact  on VendorInfo.VendorID = Contact.VendorID WHERE Last_Reviewed >= DATEADD(month, -6, GETDATE()) AND YEAR(Last_Reviewed) = YEAR(GETDATE()) ORDER BY Contact.ContactID";
       
        public const string zeroFiveVendor = "SELECT * FROM VendorInfo WHERE DATEDIFF(yy,Established_Year, GETDATE()) BETWEEN 0 AND 5";
        public const string fiveTenVendor = "SELECT * FROM VendorInfo WHERE DATEDIFF(yy,Established_Year, GETDATE()) BETWEEN 6 AND 10";
        public const string tenVendor = "SELECT * FROM VendorInfo WHERE DATEDIFF(yy,Established_Year, GETDATE()) >10";
        // SELECT * FROM VendorInfo WHERE (YEAR(GETDATE())-YEAR(Established_Year)) - (RIGHT(GETDATE(),3)<RIGHT(Established_Year,3)) BETWEEN 1 AND 5

        public const string loadVendor = "SELECT * FROM VendorInfo, ProductInfo WHERE VendorInfo.Company_Name=@company AND ProductInfo.Software_Name=@software";
        public const string loadVendor2 = "SELECT * FROM VendorInfo JOIN ProductInfo ON VendorInfo.VendorID = ProductInfo.VendorID WHERE VendorInfo.Company_Name=@company";
        public const string loadVendor3 = "SELECT * FROM VendorInfo JOIN ProductInfo ON VendorInfo.VendorID = ProductInfo.VendorID WHERE ProductInfo.Software_Name = @software";
        public const string loadContact = "SELECT * FROM Contact WHERE Contact.VendorID=@VendorID";
        public const string updateVendor = "UPDATE VendorInfo SET Company_Name=@vendor, Company_Website=@web, Description=@description, Established_Year=@eYear, No_Employees=@employ, Last_Reviewed=@lreview, Last_Demo=@lDemo, Additional_Info=@addInfo,Internal_Pro_Services=@intProService WHERE VendorID=@vendorID";
        public const string updateContact = "UPDATE Contact SET Telephone_Numbers=@number, Addresses=@address WHERE ContactID=@contactID";
        public const string updateProduct = "UPDATE ProductInfo SET Software_Name=@software, Type_Of_Software=@type, Business_Areas=@area, Modules=@module, Financial_Service_Clients=@fsc, Cloud_Service_Type=@cloud WHERE ProductID=@productID";

        // Need to sort DELETE SQL Query
        public const string deleteVendor = "DELETE FROM VendorInfo WHERE VendorID=@vendor";
        public const string deleteProduct = "DELETE FROM ProductInfo WHERE ProductID=@product";

        public const string getPDFPath = "SELECT DocumentName FROM Document WHERE VendorID=@vendor AND ProductID=@product";
        

        // UPDATE UserInformation SET Username = @Username, Password = @Password, Salt = @Salt, Email = @Email WHERE UserID = @UserID
        // Grab all the usernames, passwords and emails from the UserInfo Database table
        public const string userInfo = "SELECT * FROM UserInformation";

        public const string addVendor = "INSERT INTO VendorInfo (Company_Name, Company_Website, Description, Established_Year, No_Employees, Last_Reviewed, Last_Demo, Additional_Info, Internal_Pro_Services) VALUES (@vendor,@web,@description,@eYear,@employ,@lreview,@lDemo,@addInfo,@intProService) SELECT CAST(scope_identity() AS int)";
        public const string addContact = "INSERT INTO Contact (VendorID,Telephone_Numbers, Addresses) VALUES (@vendor,@number,@address)";
        public const string addProduct = "INSERT INTO ProductInfo (VendorID,Software_Name,Type_Of_Software, Business_Areas,Modules,Financial_Service_Clients,Cloud_Service_Type) VALUES (@vendor,@software,@type,@area,@module,@fsc,@cloud)";
        
        //Software_Name=@software, Type_Of_Software=@type, Business_Areas=@area, Modules=@module, Financial_Service_Clients=@fsc, Cloud_Service_Type=@cloud
        //INSERT INTO UserInformation (Username, Password, Salt, FirstName, LastName, Email, CompanyRole) VALUES (@Username, @Password, @Salt, @FirstName, @LastName, @Email, @CompanyRole)
        // UPDATE VendorInfo SET Company_Name=@vendor, Company_Website=@web, Description=@description, Established_Year=@eYear, No_Employees=@employ, Last_Reviewed=@lreview, Last_Demo=@lDemo, Additional_Info=@addInfo,Internal_Pro_Services=@intProService WHERE VendorID=@vendorID
    }

}
