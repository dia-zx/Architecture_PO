namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeaBuilder teaBuilder;
            TeaMaker teaMaker;

            Console.WriteLine("Приготовим черный чай!");
            teaBuilder = new BlackTeaBuilder();
            teaMaker = new TeaMaker(teaBuilder);
            teaMaker.Construct();
            Console.WriteLine(teaBuilder.GetResult().ToString());

            Console.WriteLine("Приготовим зеленый чай!");
            teaBuilder = new GreenTeaBuilder();
            teaMaker = new TeaMaker(teaBuilder);
            teaMaker.Construct();
            Console.WriteLine(teaBuilder.GetResult().ToString());
        }
    }
}
