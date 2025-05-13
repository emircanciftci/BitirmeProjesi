using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class CompanyUserVM
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string UserType { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }
        public List<CompanyUser> Comlist { get; set; }
    }
}