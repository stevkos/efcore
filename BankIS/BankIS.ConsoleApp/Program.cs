using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var c1 = new Client(city: "Brno", street: "Kopečná 23", jmeno: "Martin Novák", age: 55);
            var c2 = new Client("Tovární 17", "Praha", "Martina Novotná", 31);
            var c3 = new Client("Okružní 13", "Otrokovice", "Zdena Černá", 13);
            var c4 = new Client("Eles 11", "Zlín", "Marie Neveselá", 18);
            var c5 = new Client("Malinovského 21", "Ostrava", "Martina Nová", 22);

            List<Client> Clients = new List<Client>();
            Clients.Add(c1);
            Clients.Add(c2);
            Clients.Add(c3);
            Clients.Add(c4);
            Clients.Add(c5);
            var cnt = Clients.Count;
            Console.WriteLine($"Počet klienů v seznamu: {cnt}");

            foreach (var Lst in Clients)
            {
                Console.Write(Lst.Name + " " + Lst.Age + " ");
                Lst.HomeAddress.Print();
            }

            Console.ReadKey();



        }

    }

}
    