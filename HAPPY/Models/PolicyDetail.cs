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
    
    public partial class PolicyDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolicyDetail()
        {
            this.ClaimDetails = new HashSet<ClaimDetail>();
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int PolicyDetailID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> PolicyMasterID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public string RejectionReason { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> PolicyDocumentID { get; set; }
        public string SumAssured { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimDetail> ClaimDetails { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual PolicyMaster PolicyMaster { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}