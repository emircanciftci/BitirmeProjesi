using BP.AdminUI.Atributte;
using BP.AdminUI.Models;
using BP.BLL.Repository.Entity;
using BP.DAL.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace BP.AdminUI.Controllers
{
    //[Auth]
    public class ShippingController : BaseController
    {
        // GET: Shipping
        const string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
        public ActionResult Index()
        {
            var cxml = new XmlDocument();
            cxml.Load(bugun);

            DateTime dt = Convert.ToDateTime(cxml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            var aa = dt.ToString();

            //string usd_alis = cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteBuying").InnerXml;
            var usd_satis = (cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteSelling").InnerXml.ToString());
            var usdd = usd_satis.Replace(".", ",");
            var dollar = Convert.ToDouble(usdd);

            ShippingInsertVM vm = new ShippingInsertVM();
            vm.ShippingList = service.ShippingService.GetAll().Where(x => x.Available != false).ToList();
            vm.CargoList = service.CargoService.GetAll().Where(x => x.IsActive == true).ToList();
            vm.CompanyList = service.CompanyService.GetAll().Where(x => x.IsActive == true).ToList();
            vm.CityList = service.CityService.GetAll();
            vm.Dollar = (float)dollar;

            return View(vm);
        }

        public ActionResult Insert()
        {
            var cxml = new XmlDocument();
            cxml.Load(bugun);

            DateTime dt = Convert.ToDateTime(cxml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            var aa = dt.ToString();

            //string usd_alis = cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteBuying").InnerXml;
            var usd_satis = (cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteSelling").InnerXml.ToString());
            var usdd = usd_satis.Replace(".", ",");
            var dollar = Convert.ToDouble(usdd);

            ShippingInsertVM vm = new ShippingInsertVM();
            vm.CargoList = service.CargoService.GetAll().Where(x => x.IsActive == true).ToList();
            vm.CompanyList = service.CompanyService.GetAll().Where(x => x.IsActive == true).ToList();
            vm.CityList = service.CityService.GetAll();
            vm.Dollar = (float)dollar;
            return View(vm);
        }
        public ActionResult Update(int ID)
        {
            var cxml = new XmlDocument();
            cxml.Load(bugun);

            //string usd_alis = cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteBuying").InnerXml;
            var usd_satis = (cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteSelling").InnerXml.ToString());
            var usdd = usd_satis.Replace(".", ",");
            var dollar = Convert.ToDecimal(usdd);



            if (ID != 0)
            {

                var aa = service.ShippingService.Find(ID);

                var oneMonthAgo = (DateTime)aa.ShippingDate;
                var date = new DateTime(oneMonthAgo.Year, oneMonthAgo.Month, oneMonthAgo.Day);

                ShippingVM vm = new ShippingVM();
                vm.CompanyName = aa.Company.CompanyName;
                vm.CompanyID = (int)aa.CompanyID;
                vm.ShippingDate = (DateTime)aa.ShippingDate;
                vm.ReceiverName = aa.Receiver.ReceiverName;
                vm.ReceiverAdressName = aa.ReceiverAdress.Title + "(" + aa.ReceiverAdress.ReceiverName + "," + aa.ReceiverAdress.ReceiverPhone + "," + aa.ReceiverAdress.City.CityName + "," + aa.ReceiverAdress.District.DistrictName + "," + aa.ReceiverAdress.Quarter.QuarterName + "," + aa.ReceiverAdress.ReceiverAdress1 + ")";
                vm.CargoID = (int)aa.CargoID;
                vm.BagNumber = aa.BagNumber;
                vm.PaymentType = aa.PaymentType;
                vm.IntegrationType = aa.IntegrationType;
                vm.Vd = aa.VergiDairesi;
                vm.Vn = aa.VergiNumarası;
                vm.CargoPrice = aa.CargoPrice.ToString();
                vm.CargoList = service.CargoService.GetAll();
                vm.CargoList = service.CargoService.GetAll();
                vm.ChangePrice = (decimal)dollar;
                vm.Vd = aa.VergiDairesi;
                vm.Vn = aa.VergiDairesi;
                vm.ID = aa.ID;
                vm.ReceiverAdressID = (int)aa.ReceiverAdressID;
                return View(vm);
            }
            else
            {
                return Redirect("/Shipping/Index");
            }
        }
        public ActionResult Index1()
        {
            ShippingInsertVM vm = new ShippingInsertVM();
            vm.ShippingLogList = service.ShippingLogService.GetAll();
            vm.CargoList = service.CargoService.GetAll();
            return View(vm);
        }
        public ActionResult Index2()
        {
            ShippingInsertVM vm = new ShippingInsertVM();
            vm.ShippingList = service.ShippingService.GetAll().Where(x => x.Available != true).ToList();
            vm.CargoList = service.CargoService.GetAll();
            vm.CompanyList = service.CompanyService.GetAll();
            vm.CityList = service.CityService.GetAll();
            return View(vm);
        }

        ///alıcı listelemesi
        public JsonResult GetReceiverlist(int ID)
        {
            var result = service.ReceiverService.GetAll().Where(x => x.CompanyID == ID && x.IsActive == true).ToList();
            List<ReceiverVM> vmlist = new List<ReceiverVM>();
            foreach (var item in result)
            {
                ReceiverVM vm = new ReceiverVM();
                vm.ID = item.ID;
                vm.ReceiverName = item.ReceiverName;
                vmlist.Add(vm);
            }
            return Json(vmlist, JsonRequestBehavior.AllowGet);
        }

        ///alıcı adres listelemesi
        public JsonResult GetAdresslist(int ID)
        {
            var result = service.ReceiverAdressService.GetAll().Where(x => x.ReceiverID == ID && x.IsActive == true).ToList();
            List<ReceiverAdressVM> adrslist = new List<ReceiverAdressVM>();
            foreach (var item in result)
            {
                ReceiverAdressVM vm = new ReceiverAdressVM();
                vm.ID = item.ID;
                vm.Title = item.Title;
                vm.name = item.ReceiverName;
                vm.lastName = item.ReceiverSurname;
                vm.phone = item.ReceiverPhone;
                vm.cityID1 = (int)item.ReceiverCityID;
                var cit = service.CityService.Find(vm.cityID1);
                vm.city = cit.CityName;

                vm.districtID1 = (int)item.ReceiverDistrictID;
                var cit1 = service.DistictService.Find(vm.districtID1);
                vm.district = cit1.DistrictName;

                vm.QuarterID1 = (int)item.ReceiverQuarterID;
                var cit2 = service.QuarterService.Find(vm.QuarterID1);
                vm.Quarter = cit2.QuarterName;

                vm.adress = item.ReceiverAdress1;
                adrslist.Add(vm);
            }
            var sirala = adrslist.OrderBy(x => x.ID).ToList();
            return Json(sirala, JsonRequestBehavior.AllowGet);
        }

        //ile göre ilçe getirme
        public JsonResult GetDistrictlist(int ID)
        {
            var result = service.DistictService.GetAll().Where(x => x.CityID == ID).ToList();
            List<DistrictInsertVM> dmlist = new List<DistrictInsertVM>();
            foreach (var item in result)
            {
                DistrictInsertVM vm = new DistrictInsertVM();
                vm.ID = item.ID;
                vm.DistrictName = item.DistrictName;
                dmlist.Add(vm);
            }
            return Json(dmlist, JsonRequestBehavior.AllowGet);
        }
        //ilçeye göre mahalle listeleme
        public JsonResult GetQuarterlist(int ID)
        {
            var result = service.QuarterService.GetAll().Where(x => x.DistrictID == ID && x.IsActive == true).ToList();
            List<QuarterInsertVM> qmlist = new List<QuarterInsertVM>();
            foreach (var item in result)
            {
                QuarterInsertVM qm = new QuarterInsertVM();
                qm.ID = item.ID;
                qm.QuarterName = item.QuarterName;
                qmlist.Add(qm);
            }
            return Json(qmlist, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult recoiveradressadd(ReceiverAdressVM vm)
        {
            bool sonuc;
            if (vm.adress != null)
            {
                ReceiverAdress receiveradress = new ReceiverAdress()
                {
                    ReceiverID = vm.ReceiverID1,
                    Title = vm.Title,
                    ReceiverName = vm.name,
                    ReceiverSurname = vm.lastName,
                    ReceiverPhone = vm.phone,
                    ReceiverCityID = vm.cityID1,
                    ReceiverDistrictID = vm.districtID1,
                    ReceiverQuarterID = vm.QuarterID1,
                    ReceiverAdress1 = vm.adress,
                };
                service.ReceiverAdressService.Insert(receiveradress);
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }
            return Json(sonuc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult receiveradd(ReceiverVM vm)
        {
            bool sonuc;
            if (vm.ReceiverName != null)
            {
                if (vm.RCompanyID == '\0')
                {
                    vm.RCompanyID = 11;
                }
                else
                {

                }
                Receiver receiver = new Receiver()
                {
                    CompanyID = vm.CompanyID,
                    ReceiverName = vm.ReceiverName,
                    ReceiverPhone = vm.ReceiverPhone,
                    ReceiverCompanyID = vm.RCompanyID,
                };
                service.ReceiverService.Insert(receiver);
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }
            return Json(sonuc, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult shippingadd(ShippingVM svm)
        {
            bool sonuc = false;

            if (true)
            {
                bool durum = true;
                string iptal = "";
                if (svm.CargoID == 3)
                {
                    var aa = service.ReceiverAdressService.Find(svm.ReceiverAdressID);
                    if (aa.ReceiverDistrictID == 148 || aa.ReceiverDistrictID == 968 || aa.ReceiverDistrictID == 113)
                    {
                        durum = false;
                        iptal = "HepsiJet Dağıtım Alanı Dışında";
                    }
                    else
                    {
                    }
                }

                var price = svm.ProductPrice.Replace("$", "");
                var prics = price.Replace(",", String.Empty);
                var pric = prics.Replace(".", ",");
                var pri = Convert.ToDouble(pric);

                var change = svm.ChangePrice;
                var pri1 = Convert.ToDouble(change);

                var aa1 = service.CompanyService.Find(svm.CompanyID).İnsuranceRate;
                var ab1 = service.CompanyService.Find(svm.CompanyID).CargoPrice;
                var tut = pri / 1000;
                var tutar = tut * aa1;
                var tutar1 = tutar * pri1;
                var sonuc1 = tutar1 + ab1;

                Shipping shipping = new Shipping()
                {
                    ShippingDate = svm.ShippingDate,
                    CompanyID = svm.CompanyID,
                    ReceiverID = svm.ReceiverID,
                    ReceiverAdressID = svm.ReceiverAdressID,
                    CargoID = svm.CargoID,
                    PaymentType = svm.PaymentType,
                    IntegrationType = svm.IntegrationType,
                    BagNumber = svm.BagNumber,
                    ProductPrice = pri,
                    CargoPrice = ab1,
                    Explanation = svm.Explanation,
                    Available = durum,
                    VergiDairesi = svm.Vd,
                    VergiNumarası = svm.Vn,
                    CancelExplanation = iptal,
                };
                shipping.TotalPrice = sonuc1;
                shipping.İnsurancePrice = tutar1;
                service.ShippingService.Insert(shipping);


                var xID = service.ShippingService.GetAll().Max(x => x.ID);
                ShippingLog sl = new ShippingLog()
                {
                    ShippingID = xID,
                    BagNumber = svm.BagNumber,
                    LogDate = DateTime.Now,
                    CargoID = svm.CargoID,
                    IntegrationType = svm.IntegrationType,
                    PaymentType = svm.PaymentType,
                    ProductPrice = pri,
                    Explanation = svm.Explanation,
                    //UserName = ((SessionContext)Session["SessionContext"]).UserName,
                    Available = true
                };
                service.ShippingLogService.Insert(sl);
                sonuc = true;
            }
            else
            {

            }
            return Json(sonuc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult shippingaupdate(ShippingVM shi)
        {
            bool sonuc = false;

            if (true)
            {
                bool durum = true;
                string iptal = "";
                if (shi.CargoID == 3)
                {
                    var aa = service.ReceiverAdressService.Find(shi.ReceiverAdressID);
                    if (aa.ReceiverDistrictID == 148 || aa.ReceiverDistrictID == 968 || aa.ReceiverDistrictID == 113)
                    {
                        durum = false;
                        iptal = "HepsiJet Dağıtım Alanı Dışında";
                    }
                    else
                    {
                    }
                }
                var price = shi.ProductPrice.Replace("$", "");
                var prics = price.Replace(",", String.Empty);
                var pric = prics.Replace(".", ",");
                var pri = Convert.ToDouble(pric);
                var change = shi.ChangePrice;
                var pri1 = Convert.ToDouble(change);

                var aa1 = service.CompanyService.Find(shi.CompanyID).İnsuranceRate;
                var ab1 = service.CompanyService.Find(shi.CompanyID).CargoPrice;
                var tut = pri / 1000;
                var tutar = tut * aa1;
                var tutar1 = tutar * pri1;
                var sonuc1 = tutar1 + ab1;

                DateTime dat;
                if (shi.ShippingDate.Year == 0001)
                {
                    dat = DateTime.Now;
                }
                else
                {
                    dat = shi.ShippingDate;
                }
                Shipping shipping = new Shipping()
                {
                    ShippingDate = shi.ShippingDate,
                    CargoID = shi.CargoID,
                    PaymentType = shi.PaymentType,
                    IntegrationType = shi.IntegrationType,
                    BagNumber = shi.BagNumber,
                    ProductPrice = pri,
                    CargoPrice = ab1,
                    Explanation = shi.Explanation,
                    Available = durum,
                    VergiDairesi = shi.Vd,
                    VergiNumarası = shi.Vn,
                    CancelExplanation = iptal,
                    ID = shi.ID,
                };
                shipping.TotalPrice = sonuc1;
                shipping.İnsurancePrice = tutar1;
                service.ShippingService.ShippingUpdate(shipping);


                var xID = service.ShippingService.GetAll().Max(x => x.ID);
                ShippingLog sl = new ShippingLog()
                {
                    ShippingID = xID,
                    BagNumber = shi.BagNumber,
                    LogDate = DateTime.Now,
                    CargoID = shi.CargoID,
                    IntegrationType = shi.IntegrationType,
                    PaymentType = shi.PaymentType,
                    ProductPrice = pri,
                    Explanation = shi.Explanation,
                    //UserName = ((SessionContext)Session["SessionContext"]).UserName,
                    Available = true
                };
                service.ShippingLogService.Insert(sl);
                sonuc = true;
            }
            else
            {

            }
            return Json(sonuc, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Cancel(ShippingVM shi)
        {
            Shipping shipping = new Shipping()
            {
                ID = shi.ID,
                CancelExplanation = shi.CancelExplanation
            };
            service.ShippingService.CancelUpdate(shipping);

            var aa = service.ShippingService.Find(shi.ID);
            ShippingLog sl = new ShippingLog()
            {
                ShippingID = aa.ID,
                BagNumber = aa.BagNumber,
                LogDate = DateTime.Now,
                CargoID = aa.CargoID,
                IntegrationType = aa.IntegrationType,
                PaymentType = aa.PaymentType,
                ProductPrice = aa.ProductPrice,
                Explanation = aa.Explanation,
                Available = false,
                //UserName = ((SessionContext)Session["SessionContext"]).UserName,
            };
            service.ShippingLogService.Insert(sl);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult CargoLog(int ID)
        {
            ShippingInsertVM vm = new ShippingInsertVM();
            vm.ShippingLogList = service.ShippingLogService.GetAll().Where(x => x.ShippingID == ID).ToList();
            vm.CargoList = service.CargoService.GetAll();
            return View(vm);
        }



        [HttpPost]
        public JsonResult TrackCodee(TrackCode tc)
        {
            Shipping sh = new Shipping();
            sh.ID = tc.ID;
            sh.TrackingCode = tc.TrackCodee;
            service.ShippingService.ShippingUpdate1(sh);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

    }
}

