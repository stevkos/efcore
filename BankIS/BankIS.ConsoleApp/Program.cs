using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (BankContext context = new BankContext())
            {
                //context.Clients.FromSqlRaw("SELECT * ");

                var cnt = context.Clients.Count();
                Console.WriteLine($"Počet klientů v seznamu: {cnt}");
                Console.WriteLine();

                //seskupit podle mesta

                var groupped = context.Clients
                    .GroupBy(x => x.Age)
                    ;

                //foreach (var group in groupped)
                //{
                //    Console.WriteLine($"podle veku:  {group.Key} - pocet: ");

                foreach (var client in groupped)
                {
                    Console.WriteLine("    " + client);
                }
                

                Console.WriteLine("x");
                Console.ReadKey();

                //context.Remove(oldest);
                //context.SaveChanges();

                //context.SaveChanges();

                // LINQ

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item}");
                //}
            }
        }

    }
}