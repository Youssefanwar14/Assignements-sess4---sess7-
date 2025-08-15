namespace Assignements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1,10,15);
            Console.WriteLine(D1);
            
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);
            
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            Console.WriteLine(D4);

            D3 = D1 + D2;

            Console.WriteLine("---------------------------");

            Console.WriteLine("After adding D3 =>");
            Console.WriteLine(D3);

            Console.WriteLine("If number right D4 =>");
            D4 = D1 + 7800;
            Console.WriteLine(D4);

            Console.WriteLine("If number left D4 =>");
            D4 = 3600 + D1;
            Console.WriteLine(D4);

            Console.WriteLine("Increase one minute");
            D4 = ++D3;
            Console.WriteLine(D4);

            Console.WriteLine("Decrease one minute");
            D4 = --D3;
            Console.WriteLine(D4);

            Console.WriteLine("Subtraction: ");
            D4 = D1 - D2;
            Console.WriteLine(D4);

            Console.WriteLine("greater or less than:");
            Console.WriteLine(D1 > D2);
        }
    }
}
