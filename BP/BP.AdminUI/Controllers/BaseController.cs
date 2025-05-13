using BP.BLL.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Net.Http;
using BP.AdminUI.Models;

namespace BP.AdminUI.Controllers
{
    public class BaseController : Controller
    {
        protected EntityService service = new EntityService();
    }
}