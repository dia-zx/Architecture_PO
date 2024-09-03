using Lesson4.Models.CashOperation;
using Lesson4.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.CashProvider
{
    internal interface ICashProvider
    {
        public bool GetCashFromUser(decimal amount, IUser user);
        public int GetBankAccount();
        public void SetBankAccount(int bankAccount);
        public List<ICashOperation> GetOperations();
    }
}
