namespace method3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = -20;
            //Product product = new Product("iphone13", "apple", 100, 40, count);
            //product.GetInfo();
            //product.Sale(count);

            Phone phone = new("samsung", "galaxy", 1000, 500, 10, 64, "Cherry Red");

            phone.Balance = -12;
            phone.Calls(2);

            phone.Money(15);

            phone.Getinfo();

            Notebook notebook = new("Samsung", "Galaxy", 1000, 500, 10, "Windows", "Microprocessor", true);
            notebook.Hasgraficcard(true);
            notebook.GetInfo();
        }
    }
}