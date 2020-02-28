using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("First Name: ");
            a = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            b = Console.ReadLine();
            Console.WriteLine("Hello, " + a + " " + b + " and welcome to your first Program in C#!");
        }
    }
}