namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {
            Beverages coffee = new Coffee();
            coffee.Preparing();
            Beverages tea = new Tea();
            tea.Preparing();
            Console.ReadLine();
        }
    }
}