namespace ConsoleApp1
{
    abstract class Beverages
    {
        public void Preparing()
        {
            this.Boil();
            this.Welding();
            this.Spilling();
            this.Question();
            this.Additive();
        }
        protected void Boil()
        {
            Console.WriteLine("Кипятим воду");
        }
        protected virtual void Welding() { }
        protected void Spilling()
        {
            Console.WriteLine("Разливаем по чашкам");
        }
        protected virtual void Question() { }
        protected virtual void Additive() { }
    }
}
