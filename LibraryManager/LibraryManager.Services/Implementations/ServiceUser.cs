using LibraryManager.DomainModels.Entities;
using LibraryManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Implementations
{
    internal class ServiceUser : ServiceBase<User>, IServiceUser
    {
        public User CurrenUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void LogIn(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
