using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class ReceiverVM
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public int RCompanyID { get; set; }
    }
}