using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace systemIOIntro
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\data\AddressBook.txt";
            
            if (File.Exists(path))
            {
                
            }

            else
            {
                Console.WriteLine($"Could not find the file at {path}.");
            }

            string[] rows = File.ReadAllLines(path);

            List<Contact> contacts = new List<Contact>();

            for (int i = 1; i < rows.Length; i++)
            {

                string[] columns = rows[i].Split(',');

                Contact c = new systemIOIntro.Contact();
                c.FirstName = columns[0];
                c.LastName = columns[1];
                c.Street1 = columns[2];
                c.Street2 = columns[3];
                c.City = columns[4];
                c.State = columns[5];
                c.Zip = columns[6];

                contacts.Add(c);
            }

            foreach(var contact in contacts.OrderBy(c => c.LastName))
            {
                Console.WriteLine($"{contact.LastName}, {contact.FirstName}");
                Console.WriteLine($"{contact.Street1}");

                if (!string.IsNullOrEmpty(contact.Street2))
                    Console.WriteLine(contact.Street2);

                Console.WriteLine($"{contact.City}, {contact.State}, {contact.Zip}");

                Console.WriteLine("");
            }
        }
    }
}
