using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class GreenTeaBuilder : ITeaBuilder
    {
        private Tea _Tea = new ();

        public ITeaBuilder End()
        {
            _Tea.AddRecipeItem("*****************************");
            return this;
        }

        public Tea GetResult()
        {
            return _Tea;
        }

        public ITeaBuilder SetIngredients()
        {
            _Tea.AddRecipeItem("1 Положить пакетик зеленого чая.");
            _Tea.AddRecipeItem("2 Налить горячей воды.");
            _Tea.AddRecipeItem("3 Добавить 2 ложки песка.");
            _Tea.AddRecipeItem("4 Перемешать.");
            return this;
        }

        public ITeaBuilder SetTitle()
        {
            _Tea.AddRecipeItem("****** Зеленый чай **********");
            return this;
        }

        public ITeaBuilder Start()
        {
            _Tea.Clear();
            _Tea.AddRecipeItem("*****************************");
            return this;
        }
    }
}
