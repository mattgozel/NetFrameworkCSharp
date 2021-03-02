using FlooringMastery.BLL;
using FlooringMastery.Data;
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
    public class DeleteOrderWorkflow
    {
        public void Execute()
        {
            Console.Clear();

            Console.Write("Enter order date MM/DD/YYY: ");
            string dateInput = Console.ReadLine();

            DateTime date;

            DateTime.TryParse(dateInput, out date);

            OrderManager orderManager = OrderManagerFactory.Create(date);

            if (!File.Exists($@"C:\data\FlooringData\Orders_{date.ToString("MMddyyyy")}.txt"))
            {
                Console.WriteLine("No orders exist for entered date...");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }

            else
            {
                OrderViewRepository repo = new OrderViewRepository($@"C:\data\FlooringData\Orders_{date.ToString("MMddyyyy")}.txt");
                List<Order> orders = repo.ViewOrders(date);

                ConsoleIO.DisplayOrderDetails(orders, date);
                Console.WriteLine();

                int OrderId = ConsoleIO.GetOrderIdFromUser();

                var orderToDelete = orders.FirstOrDefault(o => o.OrderNumber == OrderId);

                if (orderToDelete == null)
                {
                    Console.WriteLine("Order number does not exist.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                else
                {
                    ConsoleIO.DisplayPreliminaryOrderInfo(orderToDelete, date);

                    Console.Write("Is this order information correct? Y/N: ");
                    string userResponse = Console.ReadLine();

                    if (userResponse == "Y")
                    {
                        DeleteOrderResponse response = orderManager.DeleteOrder(orderToDelete, date);

                        if (response.Success)
                        {
                            Console.Clear();
                            Console.WriteLine("Order deleted!");
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
    }
}
