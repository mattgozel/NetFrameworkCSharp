using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylRecordsManager.Models;
using VinylRecordsManager.Data;
using VinylRecordsManager.View;
using System.Runtime.Remoting.Messaging;

namespace VinylRecordsManager.Data
{
    public class VinylRecordsRepository
    {
        List<VinylRecords> masterList = new List<VinylRecords>();
        VinylRecords vinyl = new VinylRecords();
        VinylRecordsView userEnteredId = new VinylRecordsView();
        //List here where everything needs to save.
        public void Create(VinylRecords record)
        {
            masterList.Add(record);
        }

        public void ReadAll()
        {
            Console.WriteLine(string.Join<VinylRecords>("\n", masterList));
        }

        public List<VinylRecords> ReadById()
        {
            while (true)
            {
                int id = userEnteredId.SearchVinylRecords();
                List<VinylRecords> individualList = new List<VinylRecords>();
                var x = masterList.Any(C => C.Id == id);

                if (x == true)
                {
                    int index = masterList.FindIndex(r=> r.Id.Equals(id));
                    individualList = masterList.GetRange(index, 1);
                    foreach (VinylRecords vinyl in individualList)
                    return individualList;
                }

                else
                {
                    Console.WriteLine("\nSelected Id does not exist. Please try again.");
                }
            }
        }

        public void Update()
        {

            while (true)
            {
                int id = userEnteredId.SearchVinylRecords();
                var x = masterList.Any(C => C.Id == id);

                if (x == true)
                {
                    int index = masterList.FindIndex(r => r.Id.Equals(id));
                    masterList.RemoveAt(index);

                    VinylRecords record = new VinylRecords();
                    record = userEnteredId.EditVinylRecordsInfo();
                    masterList.Add(record);
                    break;
                }

                else
                {
                    Console.WriteLine("\nSelected Id does not exist. Please try again.");
                }
            }
        }

        public void Delete(int id)
        {
            bool confirm = userEnteredId.ConfirmRemoveDvd();

            if (confirm == true)
            {

                var x = masterList.Any(C => C.Id == id);

                while (true)
                {
                    if (x == true)
                    {
                        int index = masterList.FindIndex(r => r.Id.Equals(id));
                        masterList.RemoveAt(index);
                        Console.WriteLine("\nRecord Removed");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nSelected Id does not exist.");
                        break;
                    }
                }
            }
        }
    }
}
