//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace veryVerySad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment_()
        {
            this.Receipt_ = new HashSet<Receipt_>();
        }
    
        public double PayId_ { get; set; }
        public double CfOrderId_ { get; set; }
        public Nullable<System.DateTime> PayDate_ { get; set; }
        public string PayTime_ { get; set; }
        public string PayName_ { get; set; }
        public string PayLName_ { get; set; }
        public Nullable<double> PayAmount_ { get; set; }
        public string PayStatus_ { get; set; }
    
        public virtual ConfirmOrder_ ConfirmOrder_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt_> Receipt_ { get; set; }
    }
}
