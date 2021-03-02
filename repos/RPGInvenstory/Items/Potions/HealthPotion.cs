using RPGInventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Potions
{
    public class HealthPotion : Item
    {
        public HealthPotion()
        {
            Name = "Health Potion";
            Description = "It heals you.";
            Weight = 1;
            Type = ItemType.Potion;
        }
    }
}
