using FlooringMastery.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Data
{
    public class CreateEditedOrder
    {
        public Order Create(string customerName, string state, string productType, decimal area, DateTime date, int orderId)
        {
            Order order = new Order();

            order.OrderNumber = orderId;
            order.CustomerName = customerName;
            order.State = state;

            TaxInfoRepository repo = new TaxInfoRepository();
            var listOfTaxInfo = repo.GetTaxInfo();
            Tax tax = new Tax();
            tax = listOfTaxInfo.FirstOrDefault(t => t.StateAbbreviation == state);

            if (tax != null)
            {
                order.TaxRate = tax.TaxRate;
            }

            else
            {
                order.TaxRate = 0;
            }

            order.ProductType = productType;
            order.Area = area;

            ProductsListRepository productsListRepository = new ProductsListRepository();
            var listOfProductInfo = productsListRepository.GetProductList();
            Products product = new Products();
            product = listOfProductInfo.FirstOrDefault(p => p.ProductType == productType);

            order.CostPerSquareFoot = product.CostPerSquareFoot;
            order.LaborCostPerSquareFoot = product.LaborCostPerSquareFoot;
            order.MaterialCost = area * order.CostPerSquareFoot;
            order.LaborCost = area * order.LaborCostPerSquareFoot;
            order.Tax = (order.MaterialCost + order.LaborCost) * (order.TaxRate / 100);
            order.Total = order.MaterialCost + order.LaborCost + order.Tax;

            return order;
        }
    }
}
