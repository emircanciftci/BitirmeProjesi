using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class ShippingLogVM
    {
        public int ID { get; set; }
        public int ShippingID { get; set; }
        public string BagNumber { get; set; }
        public DateTime LogDate { get; set; }
        public int CargoID { get; set; }
        public string IntegrationType { get; set; }
        public string PaymentType { get; set; }
        public string ProductPrice { get; set; }
        public string UserName { get; set; }
    }
}