using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay37
{
    public class AddressBook
    {
        public void AddToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("Address");
            table.Columns.Add("City");
            table.Columns.Add("State");
            table.Columns.Add("ZipCode");
            table.Columns.Add("PhoneNumber");
            table.Columns.Add("Email");


            table.Rows.Add("Milan", "Biranwar", "Katraj", "Pune", "Maharashtra", "441601", "1234567892", "abcde@gamil.com");

            DisplayFirstNameFromTable(table);
            DisplayLastNameFromTable(table);
            DisplayAddressFromTable(table);
            DisplayCityFromTable(table);
            DisplayStateFromTable(table);
            DisplayZipCodeFromTable(table);
            DisplayPhoneNumberFromTable(table);
            DisplayEmailFromTable(table);

        }

        public void DisplayFirstNameFromTable(DataTable table)
        {

            var FirstName = from firstname in table.AsEnumerable() select firstname.Field<string>("FirstName");
            Console.WriteLine("FirstName: ");
            foreach (string firstName in FirstName)
            {
                Console.WriteLine(firstName);
            }

        }

        public void DisplayLastNameFromTable(DataTable table)
        {

            var LastName = from lastname in table.AsEnumerable() select lastname.Field<string>("LastName");
            Console.WriteLine("LastName: ");
            foreach (string lastName in LastName)
            {
                Console.WriteLine(lastName);
            }

        }

        public void DisplayAddressFromTable(DataTable table)
        {

            var Address = from address in table.AsEnumerable() select address.Field<string>("Address");
            Console.WriteLine("Address: ");
            foreach (string address in Address)
            {
                Console.WriteLine(address);
            }

        }

        public void DisplayCityFromTable(DataTable table)
        {

            var City = from city in table.AsEnumerable() select city.Field<string>("City");
            Console.WriteLine("City: ");
            foreach (string city in City)
            {
                Console.WriteLine(city);
            }

        }

        public void DisplayStateFromTable(DataTable table)
        {

            var State = from state in table.AsEnumerable() select state.Field<string>("State");
            Console.WriteLine("State: ");
            foreach (string state in State)
            {
                Console.WriteLine(state);
            }

        }

        public void DisplayZipCodeFromTable(DataTable table)
        {

            var ZipCode = from zipcode in table.AsEnumerable() select zipcode.Field<string>("ZipCode");
            Console.WriteLine("ZipCode: ");
            foreach (string zipcode in ZipCode)
            {
                Console.WriteLine(zipcode);
            }

        }

        public void DisplayPhoneNumberFromTable(DataTable table)
        {

            var PhoneNumber = from phonenumber in table.AsEnumerable() select phonenumber.Field<string>("PhoneNumber");
            Console.WriteLine("PhoneNumber: ");
            foreach (string phonenumber in PhoneNumber)
            {
                Console.WriteLine(phonenumber);
            }

        }

        public void DisplayEmailFromTable(DataTable table)
        {

            var Email = from email in table.AsEnumerable() select email.Field<string>("Email");
            Console.WriteLine("Email: ");
            foreach (string email in Email)
            {
                Console.WriteLine(email);
            }

        }


    }
}
