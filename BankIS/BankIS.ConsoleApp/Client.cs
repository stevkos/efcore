using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    class Client
    {
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
