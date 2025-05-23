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
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.CompanyCargo = new HashSet<CompanyCargo>();
            this.CompanyUser = new HashSet<CompanyUser>();
            this.Receiver = new HashSet<Receiver>();
            this.Receiver1 = new HashSet<Receiver>();
            this.Shipping = new HashSet<Shipping>();
        }
    
        public int ID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameTitle { get; set; }
        public Nullable<int> OutLocationID { get; set; }
        public Nullable<int> BranchID { get; set; }
        public string AccountingCode { get; set; }
        public string Mail { get; set; }
        public Nullable<int> TaxAdministrationID { get; set; }
        public string TaxNumber { get; set; }
        public string AuthorizedName { get; set; }
        public string AuthorizedPhone { get; set; }
        public Nullable<int> AuthorizedCityID { get; set; }
        public Nullable<int> AuthorizedDistrictID { get; set; }
        public string AuthorizedAdress { get; set; }
        public Nullable<double> İnsuranceRate { get; set; }
        public string PersonelName { get; set; }
        public string CustomerType { get; set; }
        public Nullable<System.DateTime> ContractStart { get; set; }
        public string ContractFile { get; set; }
        public Nullable<double> CargoPrice { get; set; }
    
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        public virtual District District { get; set; }
        public virtual TaxAdministraition TaxAdministraition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCargo> CompanyCargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyUser> CompanyUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receiver> Receiver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receiver> Receiver1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping> Shipping { get; set; }
        public virtual District District1 { get; set; }
    }
}
