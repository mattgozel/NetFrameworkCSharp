using RPGInventory;
using RPGInventory.Items.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInvenstory.Items.Containers.Restrictions
{
    class CapacityRestriction : IItemRestriction
    {
        public AddItemStatus AddItem(Item itemToAdd, Container container)
        {
            if(container.Capacity == container.CurrentIndex)
            {
                return AddItemStatus.BagIsFull;
            }

            else
            {
                return AddItemStatus.Success;
            }
        }
    }
}
