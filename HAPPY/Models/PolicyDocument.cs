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
    
    public partial class PolicyDocument
    {
        public int PolicyDocumentID { get; set; }
        public Nullable<int> PolicyDetailID { get; set; }
        public string DocumentType { get; set; }
        public Nullable<bool> Status { get; set; }
        public string URL { get; set; }
        public Nullable<int> ClaimDetailID { get; set; }
    
        public virtual ClaimDetail ClaimDetail { get; set; }
    }
}