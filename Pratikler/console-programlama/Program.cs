using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
