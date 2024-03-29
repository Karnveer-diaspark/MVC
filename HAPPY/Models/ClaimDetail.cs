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
    
    public partial class ClaimDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClaimDetail()
        {
            this.PolicyDocuments = new HashSet<PolicyDocument>();
        }
    
        public int ClaimDetailID { get; set; }
        public Nullable<long> ClaimAmount { get; set; }
        public Nullable<long> ApprovedAmount { get; set; }
        public Nullable<System.DateTime> DateTimeStamp { get; set; }
        public string ChequeNumber { get; set; }
        public string BankName { get; set; }
        public Nullable<int> PolicyDetailID { get; set; }
        public string Status { get; set; }
        public string RejectionReason { get; set; }
    
        public virtual PolicyDetail PolicyDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyDocument> PolicyDocuments { get; set; }
    }
}
