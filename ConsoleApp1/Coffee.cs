namespace ConsoleApp1
{
    class Coffee : Beverages
    {
        protected override void Welding()
        {
            Console.WriteLine("Завариваем кофе");
        }
        protected override void Additive()
        {
            Console.WriteLine("Добавляем к кофе молоко");
        }
    }
}