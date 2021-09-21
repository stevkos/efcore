using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    class Client
    {
        public Client(string name, int age, string street, string city)

        {
            Name = name;
            Age = age;
            HomeAdress = new Address();
            HomeAdress.Street = street;
            HomeAdress.City = city;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public  Address HomeAdress { get; set;}

        public void Print ()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(HomeAdress.Street);
            Console.WriteLine(HomeAdress.City);
        }
    }
}
