using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 23.7;
            string result = String.Format(new CultureInfo("en-US"), "{0:c}", number);
            Console.WriteLine(result);
            string result2 = String.Format("{0:C3}", number);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
