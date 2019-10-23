using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAPPY.Models
{
    public class CustomerDetail
    {
        public string Name { set; get; }
        public string Email{ set; get; }
        public string ContactNo { set; get; }
        public DateTime DOB{ set; get; }
        public string Street { set; get; }
        public string Address { set; get; }
        public string State{ set; get; }
        public string city { set; get; }
        public Int64 PIN { set; get; }
        public Int32 ParentID { set; get; }
        public Int32 CustomerID { set; get; }

    }
}