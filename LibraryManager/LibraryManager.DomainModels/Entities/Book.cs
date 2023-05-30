using LibraryManager.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DomainModels.Entities
{
    public class Book : BaseEntity
    {
        public Book(string isbn, string title, string author, AvilabilityStatus avilabilityStatus)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            AvilabilityStatus = avilabilityStatus;
        }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public AvilabilityStatus AvilabilityStatus { get; set; }
    }
}
