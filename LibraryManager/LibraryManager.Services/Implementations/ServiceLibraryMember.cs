using LibraryManager.DomainModels.Entities;
using LibraryManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Implementations
{
    public class ServiceLibraryMember : ServiceBase<LibraryMember>, IServiceLibraryMember
    {
        public void RegisterNewMember(LibraryMember libraryMember)
        {
            throw new NotImplementedException();
        }
    }
}
