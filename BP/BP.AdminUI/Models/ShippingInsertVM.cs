using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class ShippingInsertVM
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public List<Company> CompanyList { get; set; }
        public List<Cargo> CargoList { get; set; }
        public List<City> CityList { get; set; }
        public List<District> DistrictList { get; set; }
        public List<Shipping> ShippingList { get; set; }
        public List<TaxAdministraition> TaxList { get; set; }
        public List<ShippingLog> ShippingLogList { get; set; }
        public List<Quarter> QuarterList { get; set; }
        public List<Receiver> ReceiverList { get; set; }
        public float Dollar { get; set; }
    }
}