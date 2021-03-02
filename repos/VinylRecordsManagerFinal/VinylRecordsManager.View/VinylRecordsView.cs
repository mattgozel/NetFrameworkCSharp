using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VinylRecordsManager.Models;

namespace VinylRecordsManager.View
{
    public class VinylRecordsView
    {
        public int GetMenuChoice()
        {
            string input;
            int output;
            
            while(true)
            {
                Console.WriteLine("\nPlease select what you would like to do:");
                Console.WriteLine("\n1. Create Vinyl Record Entry");
                Console.WriteLine("2. List All Entries");
                Console.WriteLine("3. Find Entry by ID Number");
                Console.WriteLine("4. Edit Entry");
                Console.WriteLine("5. Remove Entry");
                Console.WriteLine("6. Quit Program");
                Console.Write("\nEnter your choice: ");

                input = Console.ReadLine();

                if(int.TryParse(input, out output) && output > 0 && output < 7)
                {
                    return output;
                }

                else
                {
                    Console.WriteLine("\nThat was not a valid entry, please try again.");
                }
            }
        }

        public VinylRecords GetNewVinylRecordInfo()
        {
            VinylRecords record = new VinylRecords();
            string artist = null;
            string album = null;
            double rating;
            int id;

            while (true)
            {
                string input;

                Console.Write("\nID Number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    record.Id = id;
                    break;
                }

                else
                {
                    Console.WriteLine("\nYou did not enter a valid Id number, please try again!");
                }
            }

            while (string.IsNullOrEmpty(artist))
            {
                Console.Write("Artist Name: ");
                artist = Console.ReadLine();
                record.Artist = artist;
            }

            while (string.IsNullOrEmpty(album))
            {
                Console.Write("Album Title: ");
                album = Console.ReadLine();
                record.Album = album;
            }

            while (true)
            {
                string input;

                Console.Write("Album Rating (ex 6.3): ");
                input = Console.ReadLine();

                if (double.TryParse(input, out rating))
                {
                    record.Rating = rating;
                    break;
                }

                else
                {
                    Console.WriteLine("\nYou did not enter a valid rating, please try again!\n");
                }
            }

            return record;
        }

        public void DisplayVinylRecords(List<VinylRecords> list)
        {
            Console.WriteLine(string.Join<VinylRecords>("\n", list));
        }

        public VinylRecords EditVinylRecordsInfo()
        {
            VinylRecords record = new VinylRecords();
            string artist = null;
            string album = null;
            double rating;
            int id;

            Console.WriteLine("\nPlease update the record:");

            while (true)
            {
                string input;

                Console.Write("\nID Number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    record.Id = id;
                    break;
                }

                else
                {
                    Console.WriteLine("\nYou did not enter a valid Id number, please try again!");
                }
            }

            while (string.IsNullOrEmpty(artist))
            {
                Console.Write("Artist Name: ");
                artist = Console.ReadLine();
                record.Artist = artist;
            }

            while (string.IsNullOrEmpty(album))
            {
                Console.Write("Album Title: ");
                album = Console.ReadLine();
                record.Album = album;
            }

            while (true)
            {
                string input;

                Console.Write("Album Rating (ex 6.3): ");
                input = Console.ReadLine();

                if (double.TryParse(input, out rating))
                {
                    record.Rating = rating;
                    break;
                }

                else
                {
                    Console.WriteLine("\nYou did not enter a valid rating, please try again!\n");
                }
            }

            return record;
        }

        public int SearchVinylRecords()
        {
            string input;
            int id;

            while (true)
            {
                Console.Write("\nEnter Id number for the record you want to view: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    return id;
                }

                else
                {
                    Console.WriteLine("\nYou did not enter a valid Id, please try again!");
                }
            }
        }

        public bool ConfirmRemoveDvd()
        {
            Console.Write("\nAre you sure you want to remove this record? (Enter Y or N): ");

            if(Console.ReadLine() == "Y")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
