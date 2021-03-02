using FlooringMastery.BLL;
using FlooringMastery.Models;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI.Workflows
{
    public class OrderDisplayWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Display Orders");
            Console.WriteLine("========================");
            Console.Write("Enter order date (ex 08/06/2020): ");
            string userEnteredDate = Console.ReadLine();
            DateTime date;
            DateTime.TryParse(userEnteredDate, out date);

            OrderManager manager = OrderManagerFactory.Create(date);

            if (!File.Exists($@"C:\data\FlooringData\Orders_{date.ToString("MMddyyyy")}.txt"))
            {
                Console.WriteLine("No orders exist for entered date...");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }

            else
            {

                OrderViewResponse response = manager.ViewOrder(date);

                if (response.Success)
                {
                    ConsoleIO.DisplayOrderDetails(response.Orders, date);
                }
                else
                {
                    Console.WriteLine("An error occurred: ");
                    Console.WriteLine(response.Message);
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
