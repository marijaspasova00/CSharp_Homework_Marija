using LibraryManager.DataAccess;
using LibraryManager.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Interfaces
{
    public interface IServiceBook : IServiceBase<Book>
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
        List<Book> GetAvailableBooks();
        public void GetById(int bookId);
    }
}
