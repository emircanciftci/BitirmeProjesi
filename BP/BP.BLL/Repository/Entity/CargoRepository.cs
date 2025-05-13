using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Entity
{
    public class CargoRepository : Base.BaseRepository<Cargo>
    {
        public bool cargostatuschange(int ID)
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
