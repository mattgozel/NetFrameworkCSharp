using FlooringMastery.Data;
using FlooringMastery.Models;
using FlooringMastery.Models.Interfaces;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.BLL.OrderAddRules
{
    public class OrderAddRules : IAddOrder
    {
        public OrderAddResponse AddOrder(Order order, DateTime date)
        {
            OrderAddResponse response = new OrderAddResponse();

            DateTime now = DateTime.Today;

            TaxInfoRepository repo = new TaxInfoRepository();
            var listOfStatesWithTaxInfo = repo.GetTaxInfo();
            Tax tax = new Tax();
            tax = listOfStatesWithTaxInfo.FirstOrDefault(t => t.StateAbbreviation == order.State);

            if (date.Subtract(now).Days <= 0)
            {
                response.Success = false;
                response.Message = "Date must be in the future.";
                return response;
            }

            else if (order.CustomerName == "")
            {
                response.Success = false;
                response.Message = "Customer Name cannot be blank.";
                return response;
            }

            else if (tax == null)
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
