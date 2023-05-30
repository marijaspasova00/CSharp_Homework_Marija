using LibraryManager.DomainModels.Entities;
using LibraryManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Implementations
{
    public class ServiceBook : ServiceBase<Book>, IServiceBook
    {
        public void BorrowBook(int bookId)
        {
            Book book = 
        }

        public void BorrowBook(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAvailableBooks()
        {
            throw new NotImplementedException();
        }

        public void GetById(int bookId)
        {
            return _db.SingleOrDefault(x => x.Id == id);
        }

        public void ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
