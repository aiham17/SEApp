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
        // Query to get total number of vendors
        public const string TotalNumberOfVendorsQuery = "SELECT COUNT(*) AS TotalVendors FROM VendorInfo";


        // Query to get active vendors
        public const string ActiveVendorsQuery = "SELECT Company_Name, * FROM VendorInfo WHERE Last_Reviewed >= DATEADD(month, -6, GETDATE()) AND YEAR(Last_Reviewed) = YEAR(GETDATE()) ORDER BY Last_Reviewed DESC"; // the LastReviewedDate should be in datetime format.

        // Query to get highest performing vendors
        public const string HighestPerformingVendorsQuery = "SELECT TOP 3 v.Company_Name,(SELECT COUNT(*) FROM ProductInfo p WHERE p.VendorID = v.VendorID) AS TotalProducts FROM VendorInfo v ORDER BY TotalProducts DESC";

        // Query to get lowest performing vendors
        public const string LowestPerformingVendorsQuery = "";

        // Query to get highest performing products
        public const string HighestPerformingProductsQuery = "";

        // Query to get lowest performing products
        public const string LowestPerformingProductsQuery = "";

        // Query to get highest performing market sectors
        public const string HighestPerformingMarketSectorsQuery = "";

        // Query to get lowest performing market sectors
        public const string LowestPerformingMarketSectorsQuery = "";

        // Query to get number of requests
        public const string NumberOfRequestsQuery = "";
    }

}
