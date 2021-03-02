using FlooringMastery.BLL;
using FlooringMastery.Data;
using FlooringMastery.Models;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI.Workflows
{
    public class AddOrderWorkflow
    {
        public void Execute()
        {
            Console.Clear();

            Console.Write("Enter order date MM/DD/YYY: ");
            string dateInput = Console.ReadLine();

            DateTime date;

            DateTime.TryParse(dateInput, out date);

            OrderManager orderManager = OrderManagerFactory.Create(date);

            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Please enter the customer's state (ex: MN): ");
            string state = Console.ReadLine();

            Products product = ConsoleIO.DisplayProductList();
            string productType = product.ProductType;

            decimal area;
            while (true)
            {
                Console.Write("Please enter the area: ");
                string userEnteredArea = Console.ReadLine();

                if (decimal.TryParse(userEnteredArea, out area) == true)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter a valid number...");
                }
            }

            CreatePreliminaryOrder preliminaryOrder = new CreatePreliminaryOrder();

            var order = preliminaryOrder.Create(customerName, state, productType, area, date);

            ConsoleIO.DisplayPreliminaryOrderInfo(order, date);

            Console.Write("Is this order information correct? Y/N: ");
            string userResponse = Console.ReadLine();

            if (userResponse == "Y")
            {

                OrderAddResponse response = orderManager.AddOrder(date, order);

                if (response.Success)
                {
                    Console.Clear();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Order added!");
                    Console.WriteLine($"{response.Order.OrderNumber} | {date}");
                    Console.WriteLine(response.Order.CustomerName);
                    Console.WriteLine(response.Order.State);
                    Console.WriteLine($"Product: {response.Order.ProductType}");
                    Console.WriteLine($"Materials: {response.Order.MaterialCost:c}");
                    Console.WriteLine($"Labor: {response.Order.LaborCost:c}");
                    Console.WriteLine($"Tax: {response.Order.Tax:c}");
                    Console.WriteLine($"Total: {response.Order.Total:c}");
                    Console.WriteLine("=============================================");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("An error occurred: ");
                    Console.WriteLine(response.Message);
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
