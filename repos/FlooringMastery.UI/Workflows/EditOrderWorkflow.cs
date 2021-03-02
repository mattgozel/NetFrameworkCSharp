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
    public class EditOrderWorkflow
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

                var orderToEdit = orders.FirstOrDefault(o => o.OrderNumber == OrderId);

                if (orderToEdit == null)
                {
                    Console.WriteLine("Order number does not exist.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                else
                {
                    Console.Clear();
                    Console.Write($"Enter customer name ({orderToEdit.CustomerName}): ");

                    string customerName = Console.ReadLine();
                    if (customerName == "")
                    {
                        customerName = orderToEdit.CustomerName;
                    }

                    Console.Write("Please enter the customer's state (ex: MN): ");

                    string state = Console.ReadLine();
                    if (state == "")
                    {
                        state = orderToEdit.State;
                    }

                    Products product = ConsoleIO.DisplayProductList();
                    string productType = product.ProductType;

                    Console.Write("Please enter the area: ");

                    string areaInput = Console.ReadLine();
                    decimal area;

                    if (areaInput == "")
                    {
                        area = orderToEdit.Area;
                    }

                    else
                    {
                        decimal.TryParse(areaInput, out area);
                    }

                    CreateEditedOrder editedOrder = new CreateEditedOrder();

                    var order = editedOrder.Create(customerName, state, productType, area, date, OrderId);

                    ConsoleIO.DisplayPreliminaryOrderInfo(order, date);

                    Console.Write("Is this order information correct? Y/N: ");
                    string userResponse = Console.ReadLine();

                    if (userResponse == "Y")
                    {

                        EditOrderResponse response = orderManager.EditOrder(date, order, OrderId);

                        if (response.Success)
                        {
                            Console.Clear();
                            Console.WriteLine("=============================================");
                            Console.WriteLine("Order edited!");
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
    }
}
