﻿using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Models.Interfaces
{
    public interface IEditOrder
    {
        EditOrderResponse EditOrder(int orderNumber, DateTime date, Order order);
    }
}
