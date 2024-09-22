using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// класс продукта (результат)
    /// </summary>
    internal class Tea
    {
        private List<string> _Recipe = [];

        /// <summary>
        /// Очистка рецепта приготовления чая
        /// </summary>
        public void Clear()=>_Recipe.Clear();

        /// <summary>
        /// Добавляем действие в текст рецепта
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Tea AddRecipeItem(string item) {
            _Recipe.Add(item); 
            return this;
        }

        public override string ToString()
        {
            string s=string.Empty;
            foreach (var item in _Recipe)
            {
                s += item + "\n";
            }
            return s;
        }
    }
}
