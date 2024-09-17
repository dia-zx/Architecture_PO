using Lesson8.Models;
using Lesson8.Presenters;
using Lesson8.Views;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new RestaurantPresenter(new Restaurant(), new RestaurantView()).Run();

        }
    }
}
