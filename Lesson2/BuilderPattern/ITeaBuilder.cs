using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal interface ITeaBuilder
    {
        ITeaBuilder Start();
        ITeaBuilder SetTitle();
        ITeaBuilder SetIngredients();
        ITeaBuilder End();
        Tea GetResult();
    }
}
