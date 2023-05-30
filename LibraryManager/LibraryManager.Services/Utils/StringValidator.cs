using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Services.Utils
{
    public static class StringValidator
    {
        public static int ValidNumber(string number, int range) // koga birame Role ili opcija
        {
            int num = 0;
            bool isNumber = int.TryParse(number, out num);
            if (!isNumber)
            {
                return -1;
            }
            if(num <= 0 || num > r)
            {
                return -1;
            }
            return num;
        }
        public static bool ValidateUsername(string username)
        {
            return username.Length >= 5;
        }
        public static bool ValidatePassword(string password)
        {
            if(password.Length < 6)
            {
                return false;
            }
            bool isNum = false;
            int num;
            foreach(var character in password)
            {
                isNum = int.TryParse(character.ToString(), out num);
            }
            if (!isNum)
            {
                return false;
            }
            return true;
        }
    }
}
