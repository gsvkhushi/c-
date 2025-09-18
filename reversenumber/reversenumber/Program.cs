namespace reversenumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find the reverse:");
            int num = Convert.ToInt32(Console.ReadLine());
            reverse r = new reverse(num);
            r.process();
            r.display();
        }
    }
}