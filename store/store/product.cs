namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Book", 50.50);
            p.Display();
            EProduct e = new EProduct("Watch", 2500.99, "Titan", 2);
            e.Display();
            Smartphone s = new Smartphone("Smartphone", 48000, "oneplus 11R", 1, "android");
            s.Display();
        }
    }
}