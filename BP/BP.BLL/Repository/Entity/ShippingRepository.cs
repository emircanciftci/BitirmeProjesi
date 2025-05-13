using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Entity
{
    public class ShippingRepository : Base.BaseRepository<Shipping>
    {
        public void ShippingUpdate(Shipping sh)
        {
            var dbresult = this.Find(sh.ID);
            dbresult.ShippingDate = sh.ShippingDate;
            dbresult.CargoID = sh.CargoID;
            dbresult.BagNumber = sh.BagNumber;
            dbresult.PaymentType = sh.PaymentType;
            dbresult.IntegrationType = sh.IntegrationType;
            dbresult.ProductPrice = sh.ProductPrice;
            dbresult.Explanation = sh.Explanation;
            dbresult.VergiDairesi = sh.VergiDairesi;
            dbresult.VergiNumarası = sh.VergiNumarası;
            dbresult.CompanyID = dbresult.CompanyID;
            dbresult.ReceiverID = dbresult.ReceiverID;
            dbresult.ReceiverAdressID = dbresult.ReceiverAdressID;
            this.Save();
        }
        public void CancelUpdate(Shipping sh)
        {
            var dbresult = this.Find(sh.ID);
            dbresult.Available = false;
            dbresult.CancelExplanation = sh.CancelExplanation;
            this.Save();
        }
        public void ShippingUpdate1(Shipping shi)
        {
            var result = this.Find(shi.ID);
            result.TrackingCode = shi.TrackingCode;
            this.Save();
        }
    }
}
