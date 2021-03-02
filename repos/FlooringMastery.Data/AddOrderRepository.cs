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
    public class AddOrderRepository : IAddOrder
    {
        private string _filePath;

        public AddOrderRepository(string filePath)
        {
            _filePath = filePath;
        }
        public OrderAddResponse AddOrder(Order order, DateTime date)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                string line = CreateCsvForOrder(order);

                sw.WriteLine(line);

                OrderAddResponse response = new OrderAddResponse();

                response.Order = order;

                return response;
            }
        }

        public string CreateCsvForOrder(Order order)
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", order.OrderNumber.ToString(), order.CustomerName, order.State, order.TaxRate.ToString(), order.ProductType, order.Area.ToString(), order.CostPerSquareFoot.ToString(), order.LaborCostPerSquareFoot.ToString(), order.MaterialCost.ToString(), order.LaborCost.ToString(), order.Tax.ToString(), order.Total.ToString());
        }
    }
}
