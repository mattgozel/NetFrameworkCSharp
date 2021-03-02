using RPGInventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Armor
{
    public class WoodenShield : Item
    {
        public WoodenShield()
        {
            Name = "A wooden shield";
            Description = "Kind of protects you";
            Weight = 2;
            Type = ItemType.Armor;
        }
    }
}
