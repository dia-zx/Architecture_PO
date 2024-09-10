using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class TeaMaker
    {
        public TeaMaker(ITeaBuilder teaBuilder) => _teaBuilder = teaBuilder;
        private ITeaBuilder _teaBuilder;
        public void Construct()
        {
            _teaBuilder.Start();
            _teaBuilder.SetTitle().SetIngredients();
            _teaBuilder.End();
        }
    }
}
