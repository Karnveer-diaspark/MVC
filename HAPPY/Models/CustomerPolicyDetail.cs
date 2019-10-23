using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAPPY.Models
{
    public class CustomerPolicyDetail
    {

            public int PolicyDetailID { set; get; }
            public int PolicyMasterID { set; get; }
            public int CustomerID { set; get; }
            public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string SumAssured { set; get; }


        }
    }

