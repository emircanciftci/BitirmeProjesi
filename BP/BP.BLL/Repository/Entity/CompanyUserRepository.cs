using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Entity
{
    public class CompanyUserRepository : Base.BaseRepository<CompanyUser>
    {
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
        public void updat(CompanyUser cr)
        {
            var dbresult = this.Find(cr.ID);
            dbresult.UserType = cr.UserType;
            dbresult.Name = cr.Name;
            dbresult.CompanyID = cr.CompanyID;
            dbresult.Phone  = cr.Phone;
            dbresult.Mail = cr.Mail;
            dbresult.IsActive = dbresult.IsActive;
            this.Save();
        }
    }
}
