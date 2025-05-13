using BP.AdminUI.Atributte;
using BP.AdminUI.Models;
using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BP.AdminUI.Controllers
{
    //[Auth]
    public class SettingsController : BaseController
    {
        // GET: Settings
        public ActionResult Quarter()
        {
            ShippingInsertVM ship = new ShippingInsertVM();
            ship.QuarterList = service.QuarterService.GetAll();
            ship.DistrictList = service.DistictService.GetAll();
            return View(ship);
        }   
        public ActionResult TaxAdministraition()
        {
            var ab = service.TaxAdministraitionService.GetAll();
            return View(ab);
        }
        public ActionResult Cargo()
        {
            var ac = service.CargoService.GetAll();
            return View(ac);
        }
        [HttpPost]
        //vergi dairesi kayıt
        public JsonResult Taxadd(string aa)
        {
            TaxAdministraition tax = new TaxAdministraition()
            {
                TaxName = aa,
                IsActive = true,
            };
            service.TaxAdministraitionService.Insert(tax);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public JsonResult TaxStatus(int ID)
        {
            var result = service.TaxAdministraitionService.taxstatuschange(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Cargoadd(string aa)
        {
            Cargo car = new Cargo()
            {
                CargoName = aa,
                IsActive = true,
            };
            service.CargoService.Insert(car);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CargoStatus(int ID)
        {
            var result = service.CargoService.cargostatuschange(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Quarteradd(string aa, int ab)
        {
            Quarter quar = new Quarter()
            {
                QuarterName = aa,
                DistrictID = ab,
                IsActive = true,
            };
            service.QuarterService.Insert(quar);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public JsonResult QuarterStatus(int ID)
        {
            var result = service.QuarterService.quarterstatuschange(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }





        /////SATIŞ RAPORU
        public ActionResult Reports()
        {
            if (true)
            {

            }
            ShippingInsertVM shi = new ShippingInsertVM()
            {
                CompanyList = service.CompanyService.GetAll(),
                ShippingList = service.ShippingService.GetAll(),
            };
            return View(shi);
        }
    }
}