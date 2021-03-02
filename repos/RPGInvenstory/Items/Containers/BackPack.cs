using RPGInvenstory.Items.Containers.Restrictions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public class BackPack : Container
    {
        public BackPack() : base(4)
        {
            Name = "Backpack, leather probably.";
            Description = "Rugged, tasteful.";
            Weight = 1;
            Type = ItemType.Container;

            AddRestriction(new CapacityRestriction());
        }
    }
}
