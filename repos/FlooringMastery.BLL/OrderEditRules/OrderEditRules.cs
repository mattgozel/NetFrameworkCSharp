using FlooringMastery.Data;
using FlooringMastery.Models;
using FlooringMastery.Models.Interfaces;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.BLL.OrderEditRules
{
    public class OrderEditRules : IEditOrder
    {
        public EditOrderResponse EditOrder(int orderNumber, DateTime date, Order order)
        {
            EditOrderResponse response = new EditOrderResponse();

            DateTime now = DateTime.Today;

            TaxInfoRepository repo = new TaxInfoRepository();
            var listOfStatesWithTaxInfo = repo.GetTaxInfo();
            Tax tax = new Tax();
            tax = listOfStatesWithTaxInfo.FirstOrDefault(t => t.StateAbbreviation == order.State);

            if (tax == null)
            {
                response.Success = false;
                response.Message = "State tax data does not exist, unable to sell products in selected state.";
                return response;
            }

            else if (order.Area < 100M)
            {
                response.Success = false;
                response.Message = "Minimum area for an order is 100.";
                return response;
            }

            response.Order = order;
            response.Success = true;
            return response;
        }
    }
}
