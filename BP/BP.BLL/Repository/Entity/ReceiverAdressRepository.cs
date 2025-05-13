using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Entity
{
    public class ReceiverAdressRepository : Base.BaseRepository<ReceiverAdress>
    {
        public void Update(ReceiverAdress rm)
        {
            var dbresult = this.Find(rm.ID);
            dbresult.ReceiverID = rm.ReceiverID;
            dbresult.Title = rm.Title;
            dbresult.ReceiverName = rm.ReceiverName;
            dbresult.ReceiverSurname = rm.ReceiverSurname;
            dbresult.ReceiverPhone = rm.ReceiverPhone;
            dbresult.ReceiverCityID = rm.ReceiverCityID;
            dbresult.ReceiverDistrictID = rm.ReceiverDistrictID;
            dbresult.ReceiverQuarterID = rm.ReceiverQuarterID;
            dbresult.ReceiverAdress1 = rm.ReceiverAdress1;
            dbresult.IsActive = dbresult.IsActive;
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
