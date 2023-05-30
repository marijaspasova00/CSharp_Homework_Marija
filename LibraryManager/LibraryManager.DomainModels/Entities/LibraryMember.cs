using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DomainModels.Entities
{
    public class LibraryMember : BaseEntity
    {
        public LibraryMember(string name, int membershipNumber)
        {
            Name = name;
            MembershipNumber = membershipNumber;
            BorrowedBooks = new List<Book>();
        }
        public string Name { get; set; }
        public int MembershipNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; }
    }
}
