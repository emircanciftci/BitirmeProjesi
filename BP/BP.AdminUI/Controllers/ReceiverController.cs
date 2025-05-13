using BP.AdminUI.Atributte;
using BP.AdminUI.Models;
using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace BP.AdminUI.Controllers
{
    //[Auth]
    public class ReceiverController : BaseController
    {
        // GET: Receiver
        public ActionResult Index()
        {
            ShippingInsertVM shi = new ShippingInsertVM();
            shi.ReceiverList = service.ReceiverService.GetAll();
            shi.CompanyList = service.CompanyService.GetAll();
            return View(shi);
        }

        public ActionResult Index1()
        {
            var aa = service.CompanyService.GetAll().Where(x => x.IsActive == true).ToList();
            return View(aa);
        }
        public ActionResult Index2()
        {
            ReceiverAdressVM rec = new ReceiverAdressVM();
            rec.recelist = service.ReceiverService.GetAll();
            rec.receAdresslist = service.ReceiverAdressService.GetAll();
            rec.comlist = service.CompanyService.GetAll();
            return View(rec);
        }
        public ActionResult Index3()
        {
            ReceiverAdressVM rec = new ReceiverAdressVM();
            rec.recelist = service.ReceiverService.GetAll().Where(x => x.IsActive == true).ToList();
            rec.citylist = service.CityService.GetAll();
            rec.distlist = service.DistictService.GetAll();
            rec.quarlist = service.QuarterService.GetAll().Where(x => x.IsActive == true).ToList();
            return View(rec);
        }

        [HttpPost]
        public ActionResult ReceiverAdd(ReceiverVM rm)
        {
            if (rm.CompanyID != 0)
            {
                Receiver rece = new Receiver();
                rece.CompanyID = rm.CompanyID;
                rece.ReceiverName = rm.ReceiverName;
                rece.ReceiverPhone = rm.ReceiverPhone;
                if (rm.RCompanyID != 0)
                {
                    rece.ReceiverCompanyID = rm.RCompanyID;
                }
                else
                {
                }
                rece.IsActive = true;

                service.ReceiverService.Insert(rece);
            }
            return Redirect("/Receiver/Index");
        }

        public ActionResult Update(int? ID)
        {
            if (ID != null)
            {
                var aa = service.ReceiverService.Find((int)ID);

                ReceiverUpdateVM rm = new ReceiverUpdateVM();

                rm.ReceiverName = aa.ReceiverName;
                rm.ReceiverPhone = aa.ReceiverPhone;
                if (aa.ReceiverCompanyID != 0 && aa.ReceiverCompanyID != null)
                {
                    rm.ReceiverCompanyID = (int)aa.ReceiverCompanyID;
                }
                else
                {

                }
                rm.CompanyID = (int)aa.CompanyID;
                rm.CompanyL = service.CompanyService.GetAll().Where(x => x.IsActive == true).ToList();
                rm.ID = aa.ID;

                return View(rm);
            }
            else
            {
                return Redirect("/Receiver/Index");
            }


        }
        public ActionResult UpdateAd(int? ID)
        {
            if (ID != null)
            {
                var aa = service.ReceiverAdressService.Find((int)ID);

                ReceiverAdressVM rm = new ReceiverAdressVM();

                rm.Title = aa.Title;
                rm.name = aa.ReceiverName;
                rm.lastName = aa.ReceiverSurname;
                rm.phone = aa.ReceiverPhone;
                rm.cityID1 = (int)aa.ReceiverCityID;
                rm.districtID1 = (int)aa.ReceiverDistrictID;
                rm.QuarterID1 = (int)aa.ReceiverQuarterID;
                rm.adress = aa.ReceiverAdress1;
                rm.ID = aa.ID;
                rm.ReceiverID1 = (int)aa.ReceiverID;
                rm.recelist = service.ReceiverService.GetAll().Where(x => x.IsActive == true).ToList();
                rm.citylist = service.CityService.GetAll();
                rm.distlist = service.DistictService.GetAll();
                rm.quarlist = service.QuarterService.GetAll().Where(x => x.IsActive == true).ToList();

                return View(rm);
            }
            else
            {
                return Redirect("/Receiver/Index2");
            }


        }

        [HttpPost]
        public ActionResult ReceiverUpdate(ReceiverUpdateVM rm)
        {
            if (rm.ID != 0)
            {
                Receiver rc = new Receiver();
                rc.ReceiverName = rm.ReceiverName;
                rc.ReceiverPhone = rm.ReceiverPhone;
                rc.ReceiverCompanyID = rm.ReceiverCompanyID;
                rc.CompanyID = rm.CompanyID;
                rc.IsActive = rc.IsActive;
                rc.ID = rm.ID;
                service.ReceiverService.Update(rc);
            }
            return Redirect("/Receiver/Index");
        }
        public ActionResult ReceiverAdUpdate(ReceiverAdressVM rm)
        {
            if (rm.ID != 0)
            {
                ReceiverAdress rc = new ReceiverAdress();
                rc.ID = rm.ID;
                rc.Title = rm.Title;
                rc.ReceiverName = rm.name;
                rc.ReceiverSurname = rm.lastName;
                rc.ReceiverPhone = rm.phone;
                rc.ReceiverCityID = rm.cityID1;
                rc.ReceiverDistrictID = rm.districtID1;
                rc.ReceiverQuarterID = rm.QuarterID1;
                rc.ReceiverAdress1 = rm.adress;
                rc.ReceiverID = rm.ReceiverID1;
                service.ReceiverAdressService.Update(rc);
            }
            return Redirect("/Receiver/Index2");
        }
        [HttpPost]
        public ActionResult ReceiverAddd(ReceiverAdressVM rm)
        {
            if (rm.ReceiverID1 != 0)
            {
                ReceiverAdress rec = new ReceiverAdress();
                rec.ReceiverID = rm.ReceiverID1;
                rec.Title = rm.Title;
                rec.ReceiverName = rm.name;
                rec.ReceiverSurname = rm.lastName;
                rec.ReceiverPhone = rm.phone;
                rec.ReceiverCityID = rm.cityID1;
                rec.ReceiverDistrictID = rm.districtID1;
                rec.ReceiverQuarterID = rm.QuarterID1;
                rec.ReceiverAdress1 = rm.adress;
                rec.IsActive = true;
                service.ReceiverAdressService.Insert(rec);
            }
            return Redirect("/Receiver/Index2");

        }
        public JsonResult UserStatus(int ID)
        {
            var result = service.ReceiverService.statuschange(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UserAdStatus(int ID)
        {
            var result = service.ReceiverAdressService.statuschange(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}