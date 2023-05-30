using LibraryManager.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Interfaces
{
    public interface IServiceUser : IServiceBase<User>
    {
        User CurrenUser { get; set; }
        void LogIn(string userName, string password);
        bool ChangePassword(string oldPassword, string newPassword);
    }
}
