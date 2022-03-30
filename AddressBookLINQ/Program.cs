using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------Welcome To Address Book Linq------------------------------------");
            AddressBookTable table = new AddressBookTable();
            table.AddToDataTable();
            Console.ReadKey();
           
        }
    }
}
