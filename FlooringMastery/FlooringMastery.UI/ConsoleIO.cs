using FlooringMastery.Data;
using FlooringMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI
{
    public class ConsoleIO
    {
        public static void DisplayOrderDetails(List<Order> Orders, DateTime date)
        {
            Console.Clear();

            foreach (var order in Orders)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine($"{order.OrderNumber} | {date.ToString("MM/dd/yyyy")}");
                Console.WriteLine($"{order.CustomerName}");
                Console.WriteLine($"{order.State}");
                Console.WriteLine($"Product: {order.ProductType}");
                Console.WriteLine($"Materials: {order.MaterialCost:c}");
                Console.WriteLine($"Labor: {order.LaborCost:c}");
                Console.WriteLine($"Tax: {order.Tax:c}");
                Console.WriteLine($"Total: {order.Total:c}");
                Console.WriteLine("=============================================");
                Console.WriteLine();
            }
        }

        public static int GetOrderIdFromUser()
        {
            int output;

            while(true)
            {
                Console.Write("Please enter the order number: ");

                string input = Console.ReadLine();

                if(!int.TryParse(input, out output))
                {
                    Console.WriteLine("You must enter a valid number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                return output;
            }
        }

        public static Products DisplayProductList()
        {
            ProductsListRepository repo = new ProductsListRepository();
            var productList = repo.GetProductList();

            Console.WriteLine("Product Type     Cost Per Square Foot   Labor Cost Per Square Foot");
            Console.WriteLine("==================================================================");

            for (int i = 0; i < productList.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {productList[i].ProductType}     {productList[i].CostPerSquareFoot:c}         {productList[i].LaborCostPerSquareFoot:c}");
            }

            Console.WriteLine("==================================================================");
            Console.WriteLine();

            int index;

            while (true)
            {
                Console.Write("Please enter the number of the product type: ");
                string userInput = Console.ReadLine();
                
                if(int.TryParse(userInput, out index) == false)
                {
                    Console.WriteLine("Please enter a valid number...");
                    continue;
                }

                if (index < 0 || index > productList.Count())
                {
                    Console.WriteLine($"Please enter a number between 1 and {productList.Count}");
                    continue;
                }

                break;
            }

            var product = productList[index - 1];

            return product;

        }

        public static void DisplayPreliminaryOrderInfo(Order order, DateTime date)
        {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine($"{order.OrderNumber} | {date.ToString("MM/dd/yyyy")}");
                Console.WriteLine($"{order.CustomerName}");
                Console.WriteLine($"{order.State}");
                Console.WriteLine($"Product: {order.ProductType}");
                Console.WriteLine($"Materials: {order.MaterialCost:c}");
                Console.WriteLine($"Labor: {order.LaborCost:c}");
                Console.WriteLine($"Tax: {order.Tax:c}");
                Console.WriteLine($"Total: {order.Total:c}");
                Console.WriteLine("=============================================");
                Console.WriteLine();
        }
    }
}
