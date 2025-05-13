using BP.AdminUI.Atributte;
using BP.AdminUI.Models;
using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace BP.AdminUI.Controllers
{
    //[Auth]
    public class CompanyController : BaseController
    {
        // GET: Company
        public ActionResult Index()
        {
            ShippingInsertVM ship = new ShippingInsertVM();
            ship.CompanyList = service.CompanyService.GetAll();
            ship.TaxList = service.TaxAdministraitionService.GetAll();
            return View(ship);
        }
        public ActionResult Index1()
        {
            ShippingInsertVM ship = new ShippingInsertVM();
            ship.TaxList = service.TaxAdministraitionService.GetAll().Where(x => x.IsActive == true).ToList();
            ship.CityList = service.CityService.GetAll();
            ship.DistrictList = service.DistictService.GetAll();
            ship.UserName = "dsfdf" /*((SessionContext)Session["SessionContext"]).UserName*/;
            return View(ship);
        }
        [HttpPost]
        public JsonResult CompanyAdd(CompanyVM vm)
        {
            Company com = new Company()
            {
                CompanyName = vm.CompanyName,
                CompanyNameTitle = vm.CompanyNameTitle,
                OutLocationID = vm.OutLocationID,
                BranchID = vm.BranchID,
                AccountingCode = vm.AccountingCode,
                Mail = vm.Mail,
                TaxAdministrationID = vm.TaxAdministrationID,
                TaxNumber = vm.TaxNumber,
                IsActive = vm.IsActive,
                AuthorizedName = vm.AuthorizedName,
                AuthorizedPhone = vm.AuthorizedPhone,
                AuthorizedCityID = vm.AuthorizedCityID,
                AuthorizedDistrictID = vm.AuthorizedDistrictID,
                AuthorizedAdress = vm.AuthorizedAdress,
                İnsuranceRate = vm.İnsuranceRate,
                CargoPrice = vm.CargoPrice,
                PersonelName = vm.PersonelName,
                CustomerType = vm.CustomerType,
                ContractStart = vm.ContractStart,
                ContractFile = vm.ContractFile,

            };
            service.CompanyService.Insert(com);
            return Json(true, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Index2()
        {
            var liste = service.CompanyService.GetAll().Where(x => x.IsActive == true).ToList();
            return View(liste);
        }

        [HttpPost]
        public ActionResult UserAdd(CompanyUserVM cu)
        {
            CompanyUser Cuser = new CompanyUser()
            {
                CompanyID = cu.CompanyID,
                UserType = cu.UserType,
                Name = cu.Name,
                Phone = cu.Phone,
                Mail = cu.Mail,
                IsActive = true,
            };
            service.CompanyUserService.Insert(Cuser);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index3()
        {
            var liste1 = service.CompanyUserService.GetAll();
            return View(liste1);
        }

        [HttpPost]
        public JsonResult CompanyUpdate(CompanyVM vm)
        {
            if (vm.ID != 0)
            {
                Company co = new Company();
                co.ID = vm.ID;
                co.CompanyName = vm.CompanyName;
                co.CompanyNameTitle = vm.CompanyNameTitle;
                co.Mail = vm.Mail;
                co.AccountingCode = vm.AccountingCode;
                co.TaxNumber = vm.TaxNumber;
                co.AuthorizedName = vm.AuthorizedName;
                co.AuthorizedPhone = vm.AuthorizedPhone;
                co.AuthorizedAdress = vm.AuthorizedAdress;
                co.PersonelName = vm.PersonelName;
                co.CustomerType = vm.CustomerType;
                co.ContractFile = vm.ContractFile;
                co.IsActive = vm.IsActive;
                if (vm.OutLocationID != 0)
                {
                    co.OutLocationID = (int)vm.OutLocationID;
                }
                if (vm.BranchID != 0)
                {
                    co.BranchID = (int)vm.BranchID;
                }
                if (vm.TaxAdministrationID != 0)
                {
                    co.TaxAdministrationID = (int)vm.TaxAdministrationID;
                }
                if (vm.AuthorizedCityID != 0)
                {
                    co.AuthorizedCityID = (int)vm.AuthorizedCityID;
                }
                if (vm.AuthorizedDistrictID != 0)
                {
                    co.AuthorizedDistrictID = (int)vm.AuthorizedDistrictID;
                }
                if (vm.İnsuranceRate != 0)
                {
                    co.İnsuranceRate = (int)vm.İnsuranceRate;
                }
                if (vm.CargoPrice != 0)
                {
                    co.CargoPrice = (int)vm.CargoPrice;
                }
                if (vm.ContractStart != null)
                {
                    co.ContractStart = (DateTime)vm.ContractStart;
                }
                service.CompanyService.CompanyUpdate(co);
            }
            return Json(true, JsonRequestBehavior.AllowGet);

        }
        public JsonResult UserStatus(int ID)
        {
            var result = service.CompanyUserService.statuschange(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UserStatuss(int ID)
        {
            var result = service.CompanyService.statuschange(ID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult updatee(int ID)
        {
            var aa = service.CompanyUserService.GetAll().Where(x => x.ID == ID).First();
            CompanyUserVM cv = new CompanyUserVM();
            cv.Comlist = service.CompanyUserService.GetAll();
            cv.CompanyID = (int)aa.CompanyID;
            cv.Name = aa.Name;
            cv.Phone = aa.Phone;
            cv.Mail = aa.Mail;
            cv.UserType = aa.UserType;
            cv.ID = aa.ID;
            return View(cv);

        }
        [HttpPost]
        public ActionResult UserAdd1(CompanyUserVM cu)
        {
            CompanyUser Cuser = new CompanyUser()
            {
                CompanyID = cu.CompanyID,
                UserType = cu.UserType,
                Name = cu.Name,
                Phone = cu.Phone,
                Mail = cu.Mail,
                ID = cu.ID,
            };
            service.CompanyUserService.updat(Cuser);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}