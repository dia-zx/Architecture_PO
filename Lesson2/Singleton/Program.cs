namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Паттерн Singleton *********");
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;
            if (singleton1 == singleton2) 
                Console.WriteLine("singleton1 == singleton2 Это один объект! (PASS)");
            else
                Console.WriteLine("singleton1 != singleton2 Это разные объекты! (FAIL)");
            Console.WriteLine("**********************************");
        }
    }
}
