using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int loop = 1;
           while ( loop == 1 ) { 
            string a, b;
            a:
            Console.WriteLine("First Name: ");
            a = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            b = Console.ReadLine();
            Console.WriteLine("Hello, " + a + " " + b + " and welcome to your first Program in C#!");
            string choice;
            Console.WriteLine("Continue?");
            choice = Console.ReadLine();
            if (choice == "continue")
            {
                goto a;
            }
            else
            {
                Environment.Exit(0);
            }
           }
        }
    }
}