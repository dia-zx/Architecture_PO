using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models.CashOperation
{
    internal class CashOperation : ICashOperation
    {
        private static int _nextId = 0;
        private int _id;
        private decimal _amount;
        private DateTime _date;
        private int _userId;

        public CashOperation(int userid, decimal amount)
        {
            _id = _nextId++;
            _userId = userid;
            _amount = amount;
        }
        public decimal GetAmount() => _amount;

        public DateTime GetDate() => _date;

        public int GetId() => _id;

        public int GetUserId() => _userId;
    }
}
