using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAPPY.Models
{
    public class PolicyTransaction
    {
       
            public string BankName { set; get; }
            public int TransactionID { set; get; }
            public int PolicyDetailID{ set; get; }
            public DateTime DateTimeStamp { set; get; }
            public string ChequeNumber{ set; get; }
         
        
    }
}