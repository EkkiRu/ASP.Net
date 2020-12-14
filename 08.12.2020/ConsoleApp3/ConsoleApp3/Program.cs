using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23;
            string result = String.Format("{0:d}", number);
            Console.WriteLine(result);
            string result2 = String.Format("{0:d4}", number);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
