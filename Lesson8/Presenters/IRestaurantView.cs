using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Presenters
{
    internal interface IRestaurantView
    {
        public string? ShowMenu(IEnumerable<string> strings);
        public void PrintLines(IEnumerable<string> strings);
        public string GetUserInput();
    }
}
