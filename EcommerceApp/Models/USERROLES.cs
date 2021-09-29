using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceApp.Models
{
    public static class USERROLES
    {


        public const string SUPERADMIN = "SUPERADMIN";
        public const string ECOMMERCEADMIN = "ECOMMERCEADMIN";


        public const string ORDERADMIN = SUPERADMIN + "," + ECOMMERCEADMIN + "," + "ORDERADMIN";
        public const string ADDORDER = ORDERADMIN + "," + "ADDORDER";
        public const string UPDATEORDER = ORDERADMIN + "," + "UPDATEORDER";
        public const string VIEWORDER = ORDERADMIN + "," + "VIEWORDER";
        public const string DELETEORDER = ORDERADMIN + "," + "DELETEORDER";
        public const string LOCKORDER = ORDERADMIN + "," + "LOCKORDER";
        public const string VOIDORDER = ORDERADMIN + "," + "VOIDORDER";
        public const string PRINTORDER = ORDERADMIN + "," + "PRINTORDER";
        public const string BACKDATEORDER = ORDERADMIN + "," + "VOIDORDER";
        public const string POSTDATEORDER = ORDERADMIN + "," + "PRINTORDER";
        public const string APPROVEORDER = ORDERADMIN + "," + "VOIDORDER";
        public const string DISAPPROVEORDER = ORDERADMIN + "," + "PRINTORDER";


        public const string PRODUCTADMIN = SUPERADMIN + "," + ECOMMERCEADMIN + "," + "PRODUCTADMIN";
        public const string ADDPRODUCT = PRODUCTADMIN + "," + "ADDPRODUCT";
        public const string UPDATEPRODUCT = PRODUCTADMIN + "," + "UPDATEPRODUCT";
        public const string VIEWPRODUCT = PRODUCTADMIN + "," + "VIEWPRODUCT";
        public const string DELETEPRODUCT = PRODUCTADMIN + "," + "DELETEPRODUCT";
        public const string LOCKPRODUCT = PRODUCTADMIN + "," + "LOCKPRODUCT";
        public const string VOIDPRODUCT = PRODUCTADMIN + "," + "VOIDPRODUCT";
        public const string PRINTPRODUCT = PRODUCTADMIN + "," + "PRINTPRODUCT";
        public const string BACKDATEPRODUCT = PRODUCTADMIN + "," + "VOIDPRODUCT";
        public const string POSTDATEPRODUCT = PRODUCTADMIN + "," + "PRINTPRODUCT";
        public const string APPROVEPRODUCT = PRODUCTADMIN + "," + "VOIDPRODUCT";
        public const string DISAPPROVEPRODUCT = PRODUCTADMIN + "," + "PRINTPRODUCT";

    }
}