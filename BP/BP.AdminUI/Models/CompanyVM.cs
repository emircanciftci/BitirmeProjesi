using BP.DAL.DB;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class CompanyVM
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameTitle { get; set; }
        public int OutLocationID { get; set; }
        public int BranchID { get; set; }
        public string AccountingCode { get; set; }
        public string Mail { get; set; }
        public int TaxAdministrationID { get; set; }
        public string TaxNumber { get; set; }
        public bool IsActive { get; set; }
        public string AuthorizedName { get; set; }
        public string AuthorizedPhone { get; set; }
        public int AuthorizedCityID { get; set; }
        public int AuthorizedDistrictID { get; set; }
        public string AuthorizedAdress { get; set; }
        public float İnsuranceRate { get; set; }
        public float CargoPrice { get; set; }
        public string PersonelName { get; set; }
        public string CustomerType { get; set; }
        public DateTime ContractStart { get; set; }
        public string ContractFile { get; set; }
        public List<City> CityList { get; set; }
        public List<District> DistrictList { get; set; }
        public List<Quarter> QuarterList { get; set; }
        public List<TaxAdministraition> TaxList { get; set; }
        public string UserName { get; set; }
        public int TaxID { get; set; }
    }
}