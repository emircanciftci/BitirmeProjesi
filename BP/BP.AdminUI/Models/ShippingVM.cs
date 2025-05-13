using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class ShippingVM
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public DateTime ShippingDate { get; set; }
        public int ReceiverID { get; set; }
        public int ReceiverAdressID { get; set; }
        public int CargoID { get; set; }
        public string PaymentType { get; set; }
        public string IntegrationType { get; set; }
        public string BagNumber { get; set; }
        public string ProductPrice { get; set; }
        public string Explanation { get; set; }
        public bool Available { get; set; }
        public string TrackingCode { get; set; }
        public string CargoPrice { get; set; }
        public decimal ChangePrice { get; set; }
        public string Vd { get; set; }
        public string Vn { get; set; }
        public List<Cargo> CargoList { get; set; }
        public string CompanyName { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAdressName { get; set; }
        public string CancelExplanation { get; set; }

    }
}