using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylRecordsManager.Controllers;

namespace VinylRecordManager
{
    class Program
    {
        static void Main(string[] args)
        {
            VinylRecordsController start = new VinylRecordsController();
            Console.WriteLine("Welcome to the Vinyl Records Manager CRUD Application!");
            start.Run();
        }
    }
}
