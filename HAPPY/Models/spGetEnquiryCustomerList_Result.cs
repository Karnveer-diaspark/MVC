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
    
    public partial class spGetEnquiryCustomerList_Result
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> FailedLoginCount { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public Nullable<long> PIN { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
