using System;
using System.IO;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Client c1 = new Client("Jan Gala", 14, "Objízdná 16 ", "Otrokovice" );
            Client c2 = new Client("Pavel Zálešák", 21, "Baťova 11", "Zlín");

            c1.Print();
            c2.Print();
            c1.SaveToFile("client1.txt");
            c2.SaveToFile("client2.txt");
            Console.ReadKey();

        }
    }
}
