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

        public void Print ()
        {
            Console.WriteLine(Name);
        }
    }
}
