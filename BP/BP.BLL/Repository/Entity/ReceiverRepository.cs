using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Entity
{
    public class ReceiverRepository : Base.BaseRepository<Receiver>
    {
        public void Update(Receiver rv)
        {
            var dbresult = this.Find(rv.ID);
            dbresult.ReceiverName = rv.ReceiverName;
            dbresult.ReceiverPhone = rv.ReceiverPhone;
            dbresult.CompanyID = rv.CompanyID;
            dbresult.ReceiverCompanyID = rv.ReceiverCompanyID;
            dbresult.IsActive = rv.IsActive;
            this.Save();
        }
        public bool statuschange(int ID)
        {
            bool result;
            var dbResult = this.Find(ID);
            if (dbResult.IsActive == true)
            {
                dbResult.IsActive = false;
                result = false;
            }
            else
            {
                dbResult.IsActive = true;
                result = true;
            }
            this.Save();
            return result;
        }
    }
}
