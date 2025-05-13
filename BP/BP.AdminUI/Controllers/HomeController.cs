using BP.AdminUI.Atributte;
using BP.AdminUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace BP.AdminUI.Controllers
{
    public class HomeController : BaseController
    {
        //[Auth]
        public ActionResult Index()
        {
            var oneMonthAgo = DateTime.Now.AddMonths(0);
            var date = new DateTime(oneMonthAgo.Year, oneMonthAgo.Month, 01);
            var oneMonthAgo1 = DateTime.Now.AddMonths(-1);
            var date1 = new DateTime(oneMonthAgo1.Year, oneMonthAgo1.Month, 01);
            var oneMonthAgo2 = DateTime.Now.AddMonths(-2);
            var date2 = new DateTime(oneMonthAgo2.Year, oneMonthAgo2.Month, 01);
            var oneMonthAgo3 = DateTime.Now.AddMonths(-3);
            var date3 = new DateTime(oneMonthAgo3.Year, oneMonthAgo3.Month, 01);
            var oneMonthAgo4 = DateTime.Now.AddMonths(-4);
            var date4 = new DateTime(oneMonthAgo4.Year, oneMonthAgo4.Month, 01);
            var oneMonthAgo5 = DateTime.Now.AddMonths(-5);
            var date5 = new DateTime(oneMonthAgo5.Year, oneMonthAgo5.Month, 01);
            var oneMonthAgo6 = DateTime.Now.AddMonths(-6);
            var date6 = new DateTime(oneMonthAgo6.Year, oneMonthAgo6.Month, 01);
            var oneMonthAgo7 = DateTime.Now.AddMonths(-7);
            var date7 = new DateTime(oneMonthAgo7.Year, oneMonthAgo7.Month, 01);
            var oneMonthAgo8 = DateTime.Now.AddMonths(-8);
            var date8 = new DateTime(oneMonthAgo8.Year, oneMonthAgo8.Month, 01);
            var oneMonthAgo9 = DateTime.Now.AddMonths(-9);
            var date9 = new DateTime(oneMonthAgo9.Year, oneMonthAgo9.Month, 01);
            var oneMonthAgo10 = DateTime.Now.AddMonths(-10);
            var date10 = new DateTime(oneMonthAgo10.Year, oneMonthAgo10.Month, 01);
            var oneMonthAgo11 = DateTime.Now.AddMonths(-11);
            var date11 = new DateTime(oneMonthAgo11.Year, oneMonthAgo11.Month, 01);

            var shippinglist = service.ShippingService.GetAll().Where(x => x.Available == true).ToList();
            var ilk = shippinglist.Where(x => x.ShippingDate <= DateTime.Now && x.ShippingDate >= date).ToList();
            var ilk1 = shippinglist.Where(x => x.ShippingDate <= date && x.ShippingDate >= date1).ToList();
            var ilk2 = shippinglist.Where(x => x.ShippingDate <= date1 && x.ShippingDate >= date2).ToList();
            var ilk3 = shippinglist.Where(x => x.ShippingDate <= date2 && x.ShippingDate >= date3).ToList();
            var ilk4 = shippinglist.Where(x => x.ShippingDate <= date3 && x.ShippingDate >= date4).ToList();
            var ilk5 = shippinglist.Where(x => x.ShippingDate <= date4 && x.ShippingDate >= date5).ToList();
            var ilk6 = shippinglist.Where(x => x.ShippingDate <= date5 && x.ShippingDate >= date6).ToList();
            var ilk7 = shippinglist.Where(x => x.ShippingDate <= date6 && x.ShippingDate >= date7).ToList();
            var ilk8 = shippinglist.Where(x => x.ShippingDate <= date7 && x.ShippingDate >= date8).ToList();
            var ilk9 = shippinglist.Where(x => x.ShippingDate <= date8 && x.ShippingDate >= date9).ToList();
            var ilk10 = shippinglist.Where(x => x.ShippingDate <= date9 && x.ShippingDate >= date10).ToList();
            var ilk11 = shippinglist.Where(x => x.ShippingDate <= date10 && x.ShippingDate >= date11).ToList();


            BarVM bv = new BarVM();
            bv.CargoNumber1 = ilk.Count();
            bv.CargoNumber2 = ilk1.Count();
            bv.CargoNumber3 = ilk2.Count();
            bv.CargoNumber4 = ilk3.Count();
            bv.CargoNumber5 = ilk4.Count();
            bv.CargoNumber6 = ilk5.Count();
            bv.CargoNumber7 = ilk6.Count();
            bv.CargoNumber8 = ilk7.Count();
            bv.CargoNumber9 = ilk8.Count();
            bv.CargoNumber10 = ilk9.Count();
            bv.CargoNumber11 = ilk10.Count();
            bv.CargoNumber12 = ilk11.Count();
            bv.CargoPrice1 = Convert.ToInt32(ilk.Sum(x => x.CargoPrice));
            bv.CargoPrice2 = Convert.ToInt32(ilk1.Sum(x => x.CargoPrice));
            bv.CargoPrice3 = Convert.ToInt32(ilk2.Sum(x => x.CargoPrice));
            bv.CargoPrice4 = Convert.ToInt32(ilk3.Sum(x => x.CargoPrice));
            bv.CargoPrice5 = Convert.ToInt32(ilk4.Sum(x => x.CargoPrice));
            bv.CargoPrice6 = Convert.ToInt32(ilk5.Sum(x => x.CargoPrice));
            bv.CargoPrice7 = Convert.ToInt32(ilk6.Sum(x => x.CargoPrice));
            bv.CargoPrice8 = Convert.ToInt32(ilk7.Sum(x => x.CargoPrice));
            bv.CargoPrice9 = Convert.ToInt32(ilk8.Sum(x => x.CargoPrice));
            bv.CargoPrice10 = Convert.ToInt32(ilk9.Sum(x => x.CargoPrice));
            bv.CargoPrice11 = Convert.ToInt32(ilk10.Sum(x => x.CargoPrice));
            bv.CargoPrice12 = Convert.ToInt32(ilk11.Sum(x => x.CargoPrice));
            bv.InsurancePrice1 = Convert.ToInt32(ilk.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice2 = Convert.ToInt32(ilk1.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice3 = Convert.ToInt32(ilk2.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice4 = Convert.ToInt32(ilk3.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice5 = Convert.ToInt32(ilk4.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice6 = Convert.ToInt32(ilk5.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice7 = Convert.ToInt32(ilk6.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice8 = Convert.ToInt32(ilk7.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice9 = Convert.ToInt32(ilk8.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice10 = Convert.ToInt32(ilk9.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice11 = Convert.ToInt32(ilk10.Sum(x => x.İnsurancePrice));
            bv.InsurancePrice12 = Convert.ToInt32(ilk11.Sum(x => x.İnsurancePrice));
            bv.TotalPrice1 = Convert.ToInt32(ilk.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk.Sum(x => x.İnsurancePrice));
            bv.TotalPrice2 = Convert.ToInt32(ilk1.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk1.Sum(x => x.İnsurancePrice));
            bv.TotalPrice3 = Convert.ToInt32(ilk2.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk2.Sum(x => x.İnsurancePrice));
            bv.TotalPrice4 = Convert.ToInt32(ilk3.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk3.Sum(x => x.İnsurancePrice));
            bv.TotalPrice5 = Convert.ToInt32(ilk4.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk4.Sum(x => x.İnsurancePrice));
            bv.TotalPrice6 = Convert.ToInt32(ilk5.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk5.Sum(x => x.İnsurancePrice));
            bv.TotalPrice7 = Convert.ToInt32(ilk6.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk6.Sum(x => x.İnsurancePrice));
            bv.TotalPrice8 = Convert.ToInt32(ilk7.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk7.Sum(x => x.İnsurancePrice));
            bv.TotalPrice9 = Convert.ToInt32(ilk8.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk8.Sum(x => x.İnsurancePrice));
            bv.TotalPrice10 = Convert.ToInt32(ilk9.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk9.Sum(x => x.İnsurancePrice));
            bv.TotalPrice11 = Convert.ToInt32(ilk10.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk10.Sum(x => x.İnsurancePrice));
            bv.TotalPrice12 = Convert.ToInt32(ilk11.Sum(x => x.CargoPrice)) + Convert.ToInt32(ilk11.Sum(x => x.İnsurancePrice));

            return View(bv);


            /////YILLIK
            //var oneMonthAg = DateTime.Now.AddYears(-1);
            //var dateOnl = new DateTime(oneMonthAg.Year, oneMonthAg.Month, 01);
            /////AYLIK
            //var oneMonthAgo = DateTime.Now.AddMonths(-1);
            //var dateOnly = new DateTime(oneMonthAgo.Year, oneMonthAgo.Month, 01);
            /////GÜNLÜK
            //var oneDayAgo = DateTime.Now.AddDays(-1);
            //var dateOnly1 = new DateTime(oneDayAgo.Year, oneDayAgo.Month, oneDayAgo.Day);

            /////YILLIK
            //var a = service.ShippingService.GetAll().Where(x => x.Available == true && x.ShippingDate >= dateOnl && x.ShippingDate <= DateTime.Now).ToList();
            /////AYLIK
            //var aa = service.ShippingService.GetAll().Where(x => x.Available == true && x.ShippingDate >= dateOnly && x.ShippingDate <= DateTime.Now).ToList();
            /////GÜNLÜK
            //var aa1 = service.ShippingService.GetAll().Where(x => x.Available == true && x.ShippingDate >= dateOnly1 && x.ShippingDate <= DateTime.Now).ToList();



            //BarVM bv = new BarVM();
            //bv.YCargoPrice = (float)a.Sum(x => x.CargoPrice);
            //bv.YTotal = (float)a.Sum(x => x.TotalPrice);
            //bv.YinsurancePrice = (float)a.Sum(x => x.İnsurancePrice);
            //bv.YCargoNumber = a.Count();

            //bv.ACargoPrice = (float)aa.Sum(x => x.CargoPrice);
            //bv.ATotal = (float)a.Sum(x => x.TotalPrice);
            //bv.AinsurancePrice = (float)aa.Sum(x => x.İnsurancePrice);
            //bv.ACargoNumber = aa.Count();

            //bv.GCargoPrice = (float)aa1.Sum(x => x.CargoPrice);
            //bv.GTotal = (float)a.Sum(x => x.TotalPrice);
            //bv.GinsurancePrice = (float)aa1.Sum(x => x.İnsurancePrice);
            //bv.GCargoNumber = aa1.Count();
            //return View(bv);
        }
        public ActionResult Error()
        {
            return View();
        }
    }


}