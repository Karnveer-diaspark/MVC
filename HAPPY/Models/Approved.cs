using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAPPY.Models
{
    public class Approved
    {
        public string CustomerID { set; get; }

        public string PolicyDetailID { set; get; }

        public string Status { set; get; }

        public string RejectionReason { set; get; }

        public string Password { set; get; }
    }
}