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
            //table.AddContacts();
            //table.Display();
            //table.EditContact("Shalini", "FirstName");
            //table.DeleteContact("Sampada");
            //table.GetCount("Channai","TN");
            //table.RetrieveData("Channai", "TN");
            table.SortAlphabetically("Channai");
            Console.ReadKey(); 
           
        }
    }
}
