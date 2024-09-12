using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models.User
{
    internal class User : IUser
    {

        public User(string name, string hashPassword)
        {
            _Id = _NextId++;
            _Name = name;
            _HashPassword = hashPassword;
        }

        public int GetCardNumber() => _CardNumber;
        public void SetCardNumber(int cardNumber) => _CardNumber = cardNumber;

        public string GetHashPassword() => _HashPassword;
        public void SetHashPassword(string hashPassword) => _HashPassword = hashPassword;

        public int GetId() => _Id;

        public string GetName() => _Name;
        public void SetName(string name) => _Name = name;
        public override string ToString() => $"Id: {_Id}, Name: {_Name}, CardNo: {_CardNumber}";

        private static int _NextId = 0;
        private int _CardNumber = 0;
        private int _Id;
        private string _Name;
        private string _HashPassword;
    }
}
