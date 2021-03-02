using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylRecordsManager.View;
using VinylRecordsManager.Models;
using VinylRecordsManager.Data;
using System.Net;

namespace VinylRecordsManager.Controllers
{
    public class VinylRecordsController
    {
        VinylRecordsView vinylView = new VinylRecordsView();
        VinylRecords vinyl;
        VinylRecordsRepository vinylRepo = new VinylRecordsRepository();
        //instantiate everything here
        public void Run()
        {
            while (true)
            {
                int start;
                start = vinylView.GetMenuChoice();

                switch(start)
                {
                    case 1:
                        CreateVinylRecord();
                        continue;
                    case 2:
                        DisplayVinylRecords();
                        continue;
                    case 3:
                        SearchVinylRecords();
                        continue;
                    case 4:
                        EditVinylRecord();
                        continue;
                    case 5:
                        RemoveVinylRecord();
                        continue;
                    case 6:
                        break;
                }

                break;

            }
        }
        
        private void CreateVinylRecord()
        {
            vinyl = vinylView.GetNewVinylRecordInfo();

            vinylRepo.Create(vinyl);
        }

        private void DisplayVinylRecords()
        {
            List<VinylRecords> displayList = vinylRepo.ReadAll();
            vinylView.DisplayVinylRecords(displayList);
        }

        private void SearchVinylRecords()
        {
            List<VinylRecords> currentList = new List<VinylRecords>();
            int id = vinylView.SearchVinylRecords();
            currentList = vinylRepo.ReadById(id);

            vinylView.DisplayVinylRecords(currentList);
        }

        private void EditVinylRecord()
        {
            int id = vinylView.SearchVinylRecords();
            vinyl = vinylView.EditVinylRecordsInfo();
            vinylRepo.Update(id, vinyl);
        }

        private void RemoveVinylRecord()
        {
            int id = vinylView.SearchVinylRecords();
            bool confirm = vinylView.ConfirmRemoveDvd();
            vinylRepo.Delete(id, confirm);
        }
    }
}
