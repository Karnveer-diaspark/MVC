//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HAPPY.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionID { get; set; }
        public Nullable<System.DateTime> DateTimeStamp { get; set; }
        public string ChequeNumber { get; set; }
        public string BankName { get; set; }
        public Nullable<int> PolicyDetailID { get; set; }
    
        public virtual PolicyDetail PolicyDetail { get; set; }
    }
}