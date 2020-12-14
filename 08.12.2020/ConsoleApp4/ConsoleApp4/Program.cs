using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23;
            string result = String.Format("{0:f}", number);
            Console.WriteLine(result);

            double number2 = 45.08;
            string result2 = String.Format("{0:f4}", number2);
            Console.WriteLine(result2);

            double number3 = 25.07;
            string result3 = String.Format("{0:f4}", number3);
            Console.WriteLine(result3);


        }
    }
}
