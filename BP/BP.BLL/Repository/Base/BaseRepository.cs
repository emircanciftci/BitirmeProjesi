using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        private BPEntities db;
        protected DbSet<T> table;
        public BaseRepository()
        {
            db = new BPEntities();
            table = db.Set<T>();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public virtual void Insert(T entity)
        {
            table.Add(entity);
            Save();
        }
        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T Find(long ID)
        {
            return table.Find(ID);
        }
    }
}
