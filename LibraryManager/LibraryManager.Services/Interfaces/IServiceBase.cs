using LibraryManager.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Interfaces
{
    public interface IServiceBase <T> where T : BaseEntity
    {
        List<T> ListAll();
        void RemoveById(int id);
        void AddById(T entity);
    }
}
