using Lesson4.Models.CashOperation;
using Lesson4.Models.User;
using Lesson4.Servises.UserProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.CashProvider
{
    internal class CashProvider : ICashProvider
    {
        private List<ICashOperation> _cashOperations = [];
        private int _bankAccount;

        public CashProvider(int bankAccount)
        {
            _bankAccount = bankAccount;
        }

        private bool Authorization(IUser user)
        {
            Console.WriteLine("Введите пароль");
            string? pass = Console.ReadLine();
            if (pass == null) return false;

            return UserProvider.UserProvider.CalculateHash(pass) == user.GetHashPassword();
        }


        public bool GetCashFromUser(decimal amount, IUser user)
        {
            if(!Authorization(user)) return false;
            // сдесь идет обращенин к сервису платежей (считаем что платеж прошел)
            bool isOK = true;
            if(!isOK) return false;
            _cashOperations.Add(new CashOperation(user.GetId(), amount));
            return true;
        }


        public int GetBankAccount()=> _bankAccount;
        public void SetBankAccount(int bankAccount) =>_bankAccount = bankAccount;

        public List<ICashOperation> GetOperations() => _cashOperations.ToList();
    }
}
