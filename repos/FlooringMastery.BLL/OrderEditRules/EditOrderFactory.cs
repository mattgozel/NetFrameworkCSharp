using FlooringMastery.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.BLL.OrderEditRules
{
    public class EditOrderFactory
    {
        public static IEditOrder Create()
        {
            return new OrderEditRules();
        }
    }
}
