using RPGInvenstory.Items.Containers.Restrictions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public class WetPaperSack : Container
    {
        public WetPaperSack() : base(2)
        {
            Name = "Wet Paper Bag";
            Description = "A paper bag that is wet.";
            Weight = 1;
            Type = ItemType.Container;

            AddRestriction(new CapacityRestriction());
            AddRestriction(new MaxWeightRestrictions(3));
        }
    }
}
