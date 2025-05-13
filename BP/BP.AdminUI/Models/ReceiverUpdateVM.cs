using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class ReceiverUpdateVM
    {
        public List<Company> CompanyL { get; set; }
        public int ID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public int CompanyID { get; set; }
        public int ReceiverCompanyID { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
    }
}