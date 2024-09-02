using Lesson4.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.CashProvider
{
    internal class CashProvider : ICashProvider, ICashProviderUserInterfase
    {
        public bool Authorization(string hashPassword)
        {
            Console.WriteLine("Введите пароль");
            string pass = Console.ReadLine();
            if()
        }

        public int GetBankAccount()
        {
            throw new NotImplementedException();
        }

        public bool GetCashFromUser(decimal amount, IUser user)
        {
            throw new NotImplementedException();
        }

        private string PassToHash() { }
    }
}
