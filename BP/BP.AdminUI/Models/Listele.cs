using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BP.AdminUI.Models
{
    public class Listele
    {
        public DateTime BasData { get; set; }
        public DateTime BitData { get; set; }
        public int Company { get; set; }
        public int Receiver { get; set; }
        public int City { get; set; }
        public int Cargo { get; set; }
    }
}