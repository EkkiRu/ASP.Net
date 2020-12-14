using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Формат процентов
             decimal number = 0.15345m;
             Console.WriteLine("{0:P1}", number);
            */

            /*
             * Настраиваемые форматы
            long number = 19876543210;
            string result = String.Format("{0:+# (###) ###-##-##}", number);
            Console.WriteLine(result);
            */

            /*
             * Метод ToString
            long number = 19876543210;
            Console.WriteLine(number.ToString("+# (###) ###-##-##"));
            */

            /*
             * Интерполяция строк
            int x = 8;
            int y = 7;
            string result = $"{x}+{y} = {x + y}";
            Console.WriteLine(result);
             */

        }
    }
}
