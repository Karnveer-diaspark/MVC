using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAPPY.Models
{
    public class RegisterCustomer
    {
        public int CustomerID { set; get; }
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string ContactNo { set; get; }

        public string city { set; get; }
        public DateTime DOB { set; get; }
        public string Street { set; get; }
        public string State { set; get; }
        public string PIN { set; get; }
        public string AadharNo { set; get; }

        public int PolicyMasterID { set; get; }
        public string SumAssured { set; get; }

        public int PolicyDetailID { set; get; }
        public string ChequeNumber { set; get; }
        public string BankName { set; get; }
        public int EnquiryID { set; get; }
    }

}
