//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BP.DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shipping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shipping()
        {
            this.ShippingLog = new HashSet<ShippingLog>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> ShippingDate { get; set; }
        public Nullable<int> ReceiverID { get; set; }
        public Nullable<int> ReceiverAdressID { get; set; }
        public Nullable<int> CargoID { get; set; }
        public string PaymentType { get; set; }
        public string IntegrationType { get; set; }
        public string BagNumber { get; set; }
        public Nullable<double> ProductPrice { get; set; }
        public string Explanation { get; set; }
        public Nullable<bool> Available { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string TrackingCode { get; set; }
        public Nullable<double> CargoPrice { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNumarası { get; set; }
        public Nullable<double> İnsurancePrice { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public string CancelExplanation { get; set; }
    
        public virtual Receiver Receiver { get; set; }
        public virtual ReceiverAdress ReceiverAdress { get; set; }
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingLog> ShippingLog { get; set; }
        public virtual Cargo Cargo { get; set; }
    }
}
