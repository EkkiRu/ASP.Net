using System;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Класс StringBuilder
            StringBuilder sb = new StringBuilder("Hello world");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            */

            /*
             * 2
            StringBuilder sb = new StringBuilder("Name: ");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");

            sb.Append(" Руководство");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");

            sb.Append(" по С#");
            Console.WriteLine($"Длина строки: {sb.Length}");
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
            */

            /*
             * 3
            
            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "Компьютерный ");
            Console.WriteLine(sb);

            sb.Replace("мир", "world");
            Console.WriteLine(sb);

            sb.Remove(7, 13);
            Console.WriteLine(sb);

            string s = sb.ToString();
            Console.WriteLine(s);
             */
        }
    }
}
