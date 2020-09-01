using FlooringMastery.Models;
using FlooringMastery.Models.Interfaces;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Data
{
    public class EditOrderRepository : IEditOrder
    {
        private string _filePath;

        public EditOrderRepository(string filePath)
        {
            _filePath = filePath;
        }

        public string CreateCsvForOrder(Order order)
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", order.OrderNumber.ToString(), order.CustomerName, order.State, order.TaxRate.ToString(), order.ProductType, order.Area.ToString(), order.CostPerSquareFoot.ToString(), order.LaborCostPerSquareFoot.ToString(), order.MaterialCost.ToString(), order.LaborCost.ToString(), order.Tax.ToString(), order.Total.ToString());
        }

        public EditOrderResponse EditOrder(int orderNumber, DateTime date, Order order)
        {
            OrderViewRepository repo = new OrderViewRepository(_filePath);
            List<Order> orders = repo.ViewOrders(date);

            var index = orders.FindIndex(o => o.OrderNumber == orderNumber);

            orders[index] = order;

            CreateOrderFile(orders);

            EditOrderResponse response = new EditOrderResponse();

            response.Order = order;

            return response;
        }

        private void CreateOrderFile(List<Order> orders)
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);

            using(StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine("OrderNumber,CustomerName,State,TaxRate,ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,MaterialCost,LaborCost,Tax,Total");

                foreach(var order in orders)
                {
                    sw.WriteLine(CreateCsvForOrder(order));
                }
            }
        }
    }
}
