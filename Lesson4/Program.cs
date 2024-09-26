using Lesson4.Customer;
namespace Lesson4
{
    internal class Program
    {
        private static ICustomer _customer;

        static void Main(string[] args)
        {
            Init();
            do
            {
                PrintMenu();
                string UserInput = Console.ReadLine();
                if (UserInput == "0") break;

                switch (UserInput)
                {
                    case "1": CreateNewUser(); break;
                    case "2": DeleteUser(); break;
                    case "3":
                        _customer.GetUserProvider().GetUsers().Select(x => { Console.WriteLine(x.ToString()); return x; }).ToList();
                        Console.Write("Нажмите <Enter> "); Console.ReadLine();
                        break;
                    case "4":
                        _customer.GetTicketProvider().GetTickets().Select(x => { Console.WriteLine(x.ToString()); return x; }).ToList();
                        Console.Write("Нажмите <Enter> "); Console.ReadLine();
                        break;
                    case "5":
                        _customer.GetCashProvider().GetOperations().Select(x => { Console.WriteLine(x.ToString()); return x; }).ToList();
                        Console.Write("Нажмите <Enter> "); Console.ReadLine();
                        break;
                    case "6": BuyTicket(); break;
                    default:
                        break;
                }

            } while (true);
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Меню операций с системой обслуживания билетов");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1 - Создание нового пользователя");
            Console.WriteLine("2 - Удаление пользователя");
            Console.WriteLine("3 - Список пользователей");
            Console.WriteLine("4 - Список билетов");
            Console.WriteLine("5 - Список банковских операций");
            Console.WriteLine("6 - Покупка билета");
            Console.WriteLine("0 - Выход");
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Ваш выбор: ");
        }

        static void Init()
        {
            _customer = new Customer.Customer();

            int id1 = _customer.GetUserProvider().CreateUser("Denis", "1").GetId();
            _customer.GetTicketProvider().CreateTicket(id1, 10, 100.99m, 10);

            int id2 = _customer.GetUserProvider().CreateUser("Ann", "1").GetId();
            _customer.GetTicketProvider().CreateTicket(id2, 10, 20.759m, 3);

        }

        public static void CreateNewUser()
        {
            Console.Write("Введите имя нового пользователя: ");
            string name = Console.ReadLine();
            Console.Write("Введите пароль нового пользователя: ");
            string password = Console.ReadLine();

            _customer.GetUserProvider().CreateUser(name, password);
        }

        public static void DeleteUser()
        {
            Console.Write("Введите ID пользователя: ");
            do
            {
                string? sid = Console.ReadLine();
                int id;
                if (!int.TryParse(sid, out id)) continue;
                _customer.GetUserProvider().DeleteUser(id);
                break;
            } while (true);
        }

        public static void BuyTicket()
        {
            var userProvider = _customer.GetUserProvider();
            var cashProvider = _customer.GetCashProvider();
            var ticketProvider = _customer.GetTicketProvider();
            Console.Write("Введите ID пользователя: ");
            int userId;
            const int PRICE = 10;
            do
            {
                string? sid = Console.ReadLine();
                if (!int.TryParse(sid, out userId)) continue;
                break;
            } while (true);

            try
            {
                if (cashProvider.GetCashFromUser(PRICE, userProvider.GetUser(userId)))
                {
                    ticketProvider.CreateTicket(userId, 0, PRICE, 0);
                    Console.WriteLine("Авторизация успешна, билет куплен!");
                }
                else
                    Console.WriteLine("Ошибка авторизации!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка полученния пользователя с указанным Id: ");
            }
            Console.Write("Нажмите <Enter> "); Console.ReadLine();


        }
    }
}
