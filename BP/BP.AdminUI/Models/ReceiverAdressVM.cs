using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class ReceiverAdressVM
    {
        public int ID { get; set; }
        public int ReceiverID1 { get; set; }
        public string Title { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public int cityID1 { get; set; }
        public string city { get; set; }
        public int districtID1 { get; set; }
        public string district { get; set; }
        public int QuarterID1 { get; set; }
        public string Quarter { get; set; }
        public string adress { get; set; }
        public List<Receiver> recelist { get; set; }
        public List<ReceiverAdress> receAdresslist { get; set; }
        public List<Company> comlist { get; set; }
        public List<City> citylist { get; set; }
        public List<District> distlist { get; set; }
        public List<Quarter> quarlist { get; set; }
    }
}