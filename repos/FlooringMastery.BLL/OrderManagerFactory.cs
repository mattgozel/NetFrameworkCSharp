using FlooringMastery.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.BLL
{
    public static class OrderManagerFactory
    {
        public static OrderManager Create(DateTime date)
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            switch(mode)
            {
                case "OrderTest":
                    return new OrderManager(new OrderViewRepository(@"C:\data\FlooringData\Orders_06012013.txt"));
                case "OrderProd":
                    return new OrderManager(new OrderViewRepository($@"C:\data\FlooringData\Orders_{date.ToString("MMddyyyy")}.txt"));
                default:
                    throw new Exception("Mode value in app config is not valid");
            }
        }
    }
}
