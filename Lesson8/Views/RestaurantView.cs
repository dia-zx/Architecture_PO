using Lesson8.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Views;

internal class RestaurantView : IRestaurantView
{
    public string? GetUserInput()
    {
        return Console.ReadLine();
    }

    public void PrintLines(IEnumerable<string> strings)
    {
        foreach (string s in strings)
            Console.WriteLine(s);
    }

    public string? ShowMenu(IEnumerable<string> strings)
    {
        Console.Clear();
        Console.WriteLine("************** Меню сервиса ресторана **********************");
        PrintLines(strings);
        Console.WriteLine("************************************************************");
        Console.Write("Введите пункт меню: ");
        return GetUserInput();
    }
}

