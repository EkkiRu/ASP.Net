using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Tom", Age = 23 };
            Console.WriteLine("Name: {0} Age: {1}", person.Name, person.Age);
            //Интерполяция строк
            //Console.WriteLine("Name: {person.Name} Age: {person.Age}");
            Console.Read();
        }

        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
