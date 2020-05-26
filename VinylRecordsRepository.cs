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
        //List here where everything needs to save.
        public VinylRecords Create(VinylRecords record)
        {
            masterList.Add(record);
            return record;
        }

        public List<VinylRecords> ReadAll()
        {
            return masterList;
        }

        public List<VinylRecords> ReadById(int id)
        {
            while (true)
            {
                List<VinylRecords> individualList = new List<VinylRecords>();

                foreach (VinylRecords idSearch in masterList)
                {
                    if (masterList.ToString().Contains(id.ToString()))
                    {
                        int index = masterList.FindIndex(delegate (VinylRecords recordSearch)
                        {
                            return recordSearch.Id.Equals(id);
                        });
                        individualList = masterList.GetRange(index, 1);
                            return individualList;
                    }

                    else
                    {
                        Console.WriteLine("\nSelected Id does not exist. Please try again.");
                        return individualList;
                    }
                }
            }
        }

        public void Update(int id, VinylRecords record)
        {
            while (true)
            {
                foreach (VinylRecords idSearch in masterList)
                {
                    if (masterList.ToString().Contains(id.ToString()))
                    {
                        int index = masterList.FindIndex(delegate (VinylRecords recordSearch)
                        {
                            return recordSearch.Id.Equals(id);
                        });

                        masterList.RemoveAt(index);
                        masterList.Add(record);
                        break;
                    }

                    else
                    {
                        Console.WriteLine("\nSelected Id does not exist. Please try again.");
                        break;
                    }
                }

                break;

            }
        }

        public void Delete(int id, bool confirm)
        {

            if (confirm == true)
            {
                while (true)
                {
                    foreach (VinylRecords idSearch in masterList)
                    {
                        if (masterList.ToString().Contains(id.ToString()))
                        {
                            int index = masterList.FindIndex(delegate (VinylRecords recordSearch)
                            {
                                return recordSearch.Id.Equals(id);
                            });

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

                    break;
                }
            }
        }
    }
}
