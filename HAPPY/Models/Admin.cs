using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAPPY.Models
{
    public class Admin
    {
        public int CustomerID { set; get; }
        public string Email { set; get; }
        public string ContactNo { set; get; }
        public string Name { set; get; }
        public DateTime DOB { set; get; }
        public string Address { set; get; }
        public string Street { set; get; }
        public string city { set; get; }
        public string State { set; get; }
        public Int16 PIN { set; get; }
        public int PolicyDetailID { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string RejectionReson { set; get; }
        public string SumAssured { set; get; }
    }
}