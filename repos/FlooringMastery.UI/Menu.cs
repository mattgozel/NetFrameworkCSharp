using FlooringMastery.UI.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI
{
    public static class Menu
    {
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Flooring Mastery");
                Console.WriteLine("======================");
                Console.WriteLine("1. Display Orders");
                Console.WriteLine("2. Add an Order");
                Console.WriteLine("3. Edit an Order");
                Console.WriteLine("4. Remove an Order");
                Console.WriteLine("5. Quit");
                Console.Write("\nEnter Selection: ");

                string userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        OrderDisplayWorkflow displayWorkflow = new OrderDisplayWorkflow();
                        displayWorkflow.Execute();
                        break;
                    case "2":
                        AddOrderWorkflow addOrderWorkflow = new AddOrderWorkflow();
                        addOrderWorkflow.Execute();
                        break;
                    case "3":
                        EditOrderWorkflow editOrderWorkflow = new EditOrderWorkflow();
                        editOrderWorkflow.Execute();
                        break;
                    case "4":
                        DeleteOrderWorkflow deleteOrderWorkflow = new DeleteOrderWorkflow();
                        deleteOrderWorkflow.Execute();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("That is not a valid choice. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
