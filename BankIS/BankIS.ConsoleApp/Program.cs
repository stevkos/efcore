using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Linq;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        /*    var c1 = new Client(city: "Brno", street: "Kopečná 23", jmeno: "Martin Novák", age: 55);
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
                Lst.Print();
                
            }
            Client.SaveListToFile("allclients.txt", Clients);*/

            Console.WriteLine ("Načítám clients ze souboru");
            var clients = Client.ReadListFromFile("dataset_1.txt");

            var cnt = clients.Count;
            Console.WriteLine($"Počet: {cnt}");

            foreach (var lst in clients)
            {
                lst.Print();

            }
            //  int age = 30;
            //  var result = clients.Where(client => client.Age > age).ToList();
            //  Console.WriteLine($"Přes {age}:");

            //  var result = clients.OrderBy(client => client.Age).ToList();
            // Console.WriteLine($"Řazení podle věku");

            var result = clients.Where(Client => Client.HomeAddress.City == "Olomouc" && Client.Age >= 20 && Client.Age <= 40).ToList();
             Console.WriteLine("Olomouc mezi 20 a 40");
            Console.WriteLine(result);

                foreach (var lst in result)
                {
                    lst.Print();

             }
            Console.ReadKey();

        }

    }

}
    