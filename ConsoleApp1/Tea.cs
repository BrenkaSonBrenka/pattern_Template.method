namespace ConsoleApp1
{
    class Tea : Beverages
    {
        bool Flag { get; set; }
        protected override void Welding()
        {
            Console.WriteLine("Завариваем чай");
        }
        protected override void Question()
        {
            Console.WriteLine("Добавить что-либо к чаю?(yes,no) ");
            string add = Console.ReadLine();
            switch (add)
            {
                case "yes":
                    {
                        Flag = true;
                        break;
                    }
                case "no":
                    {
                        Flag = false;
                        break;
                    }
                default: break; //base.Question();
            }

        }
        protected override void Additive()
        {
            if (Flag)
                Console.WriteLine("Добавляем к чаю лимон");
            else
                Console.WriteLine("К чаю ничего не добавляем");

        }
    }
}
