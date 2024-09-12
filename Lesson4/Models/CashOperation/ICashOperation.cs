using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models.CashOperation
{
    internal interface ICashOperation
    {
        public int GetId();
        public int GetUserId();
        public DateTime GetDate();
        public decimal GetAmount();
    }
}
