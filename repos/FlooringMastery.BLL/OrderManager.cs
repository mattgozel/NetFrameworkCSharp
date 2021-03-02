using FlooringMastery.BLL.OrderAddRules;
using FlooringMastery.BLL.OrderEditRules;
using FlooringMastery.Data;
using FlooringMastery.Models;
using FlooringMastery.Models.Interfaces;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.BLL
{
    public class OrderManager
    {
        private IViewOrder _orderRepository;

        public OrderManager(IViewOrder orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderViewResponse ViewOrder(DateTime date)
        {
            OrderViewResponse response = new OrderViewResponse();

            response.Orders = _orderRepository.ViewOrders(date);

            if(response.Orders == null)
            {
                response.Success = false;
                response.Message = $"There is no order listed on {date}";
            }

            else
            {
                response.Success = true;
            }

            return response;
        }

        public OrderAddResponse AddOrder(DateTime orderDate, Order order)
        {
            OrderAddResponse response = new OrderAddResponse();            

            response.Order = order;

            IAddOrder orderAddRules = AddOrderFactory.Create();

            response = orderAddRules.AddOrder(response.Order, orderDate);

            if(response.Success)
            {
                if(!File.Exists($@"C:\data\FlooringData\Orders_{orderDate.ToString("MMddyyyy")}.txt"))
                {
                    string[] lines = new string[]
                    {
                        "OrderNumber,CustomerName,State,TaxRate,ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,MaterialCost,LaborCost,Tax,Total"
                    };

                    File.WriteAllLines($@"C:\data\FlooringData\Orders_{orderDate.ToString("MMddyyyy")}.txt", lines);
                }
                
                AddOrderRepository repo = new AddOrderRepository($@"C:\data\FlooringData\Orders_{orderDate.ToString("MMddyyyy")}.txt");

                repo.AddOrder(response.Order, orderDate);
            }

            return response;
        }

        public EditOrderResponse EditOrder(DateTime orderDate, Order order, int orderId)
        {
            EditOrderResponse response = new EditOrderResponse();

            response.Order = order;

            IEditOrder orderEditRules = EditOrderFactory.Create();

            response = orderEditRules.EditOrder(response.Order.OrderNumber, orderDate, response.Order);

            if(response.Success)
            {
                EditOrderRepository repo = new EditOrderRepository($@"C:\data\FlooringData\Orders_{orderDate.ToString("MMddyyy")}.txt");

                repo.EditOrder(response.Order.OrderNumber, orderDate, response.Order);
            }

            return response;

        }

        public DeleteOrderResponse DeleteOrder(Order order, DateTime orderDate)
        {
            DeleteOrderResponse response = new DeleteOrderResponse();

            response.Order = order;

            response.Success = true;

            DeleteOrderRepository repo = new DeleteOrderRepository($@"C:\data\FlooringData\Orders_{orderDate.ToString("MMddyyyy")}.txt");

            repo.DeleteOrder(order.OrderNumber, orderDate, order);

            return response;
        }
    }
}
