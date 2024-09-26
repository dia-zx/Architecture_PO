using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models.User
{
    internal interface IUser
    {
        public int GetId();
        public string GetName();
        public void SetName(string name);
        public string GetHashPassword();
        public void SetHashPassword(string hashPassword);
        public int GetCardNumber();
        public void SetCardNumber(int cardNumber);
    }
}
