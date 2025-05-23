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
    
    public partial class ReceiverAdress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceiverAdress()
        {
            this.Shipping = new HashSet<Shipping>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ReceiverID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverSurname { get; set; }
        public string ReceiverPhone { get; set; }
        public Nullable<int> ReceiverCityID { get; set; }
        public Nullable<int> ReceiverDistrictID { get; set; }
        public Nullable<int> ReceiverQuarterID { get; set; }
        public string ReceiverAdress1 { get; set; }
        public string Title { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual City City { get; set; }
        public virtual District District { get; set; }
        public virtual Quarter Quarter { get; set; }
        public virtual Receiver Receiver { get; set; }
        public virtual Receiver Receiver1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping> Shipping { get; set; }
    }
}
