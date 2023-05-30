using LibraryManager.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Interfaces
{
    public interface IServiceLibraryMember : IServiceBase<LibraryMember>
    {
        void RegisterNewMember(LibraryMember libraryMember);
    }
}
