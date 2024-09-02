using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.CashProvider
{
    internal interface ICashProviderUserInterfase
    {
        public bool Authorization(string Password);
    }
}
