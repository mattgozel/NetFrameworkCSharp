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
        VinylRecordsView currentVinylRecord = new VinylRecordsView();
        VinylRecords vinyl;
        VinylRecordsRepository listCreator = new VinylRecordsRepository();
        //instantiate everything here
        public void Run()
        {
            while (true)
            {
                int start;
                start = currentVinylRecord.GetMenuChoice();

                if (start == 1)
                {
                    CreateVinylRecord();
                }

                if (start == 2)
                {
                    DisplayVinylRecords();
                }

                if (start == 3)
                {
                    SearchVinylRecords();
                }

                if (start == 4)
                {
                    EditVinylRecord();
                }

                if (start == 5)
                {
                    RemoveVinylRecord();
                }

                if (start == 6)
                {
                    break;
                }
            }
        }
        
        private void CreateVinylRecord()
        {
            vinyl = currentVinylRecord.GetNewVinylRecordInfo();

            listCreator.Create(vinyl);
        }

        private void DisplayVinylRecords()
        {
            listCreator.ReadAll();
        }

        private void SearchVinylRecords()
        {
            List<VinylRecords> currentList = new List<VinylRecords>();
            currentList = listCreator.ReadById();

            currentVinylRecord.DisplayVinylRecord(currentList);
        }

        private void EditVinylRecord()
        {
            listCreator.Update();
        }

        private void RemoveVinylRecord()
        {
            int id = currentVinylRecord.SearchVinylRecords();
            listCreator.Delete(id);
        }
    }
}
