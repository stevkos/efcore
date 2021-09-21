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
        }
    }
}
