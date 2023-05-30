using LibraryManager.DataAccess;
using LibraryManager.DomainModels.Entities;
using LibraryManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Implementations
{
    public class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected IDb<T> _db;
        public ServiceBase()
        {
            _db = new LocalDb<T>();
        }
        public void AddById(T entity)
        {
            _db.Insert(entity);
        }

        public List<T> ListAll()
        {
            return _db.GetAll();
        }

        public void RemoveById(int id)
        {
            _db.DeleteById(id);
        }
    }
}
