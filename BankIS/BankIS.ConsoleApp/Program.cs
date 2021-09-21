using System;
using System.IO;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Client c1 = new Client("Jan Gala", 14, "Objízdná", "Otrokovice" );
           
            c1.Print();
            Console.ReadKey();

        }
    }
}
