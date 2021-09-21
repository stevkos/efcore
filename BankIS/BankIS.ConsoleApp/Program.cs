using System;
using System.IO;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Client c1 = new Client();
            c1.Name = "Jan Novák";
            c1.Age = 31;
            c1.Print();
            Client c2 = new Client();
            c2.Name = "Jana Nová";
            c2.Age = 28;
            c2.Print();
            Console.ReadKey();

        }
    }
}
