using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    internal class AddressBookTable
    {
        //Creating method to add data to table
        public void AddToDataTable()
        {
            //Creating object of class
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("Address");
            table.Columns.Add("City");
            table.Columns.Add("State");
            table.Columns.Add("Zip");
            table.Columns.Add("PhoneNumber");
            table.Columns.Add("Email");
        }
    }
}
