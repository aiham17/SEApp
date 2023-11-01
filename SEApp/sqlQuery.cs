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

        // Query to get total number of vendors
        public const string TotalNumberOfVendorsQuery = "SELECT COUNT(*) AS TotalVendors FROM VendorInfo";


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
    }

}
