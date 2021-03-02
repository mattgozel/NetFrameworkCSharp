using RPGInventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Weapons
{
    public class Sword : Item
    {
        public Sword()
        {
            Name = "A Wooden Sword!";
            Description = "It's dangerous to go it alone, take this with you.";
            Weight = 3;
            Type = ItemType.Weapon;
        }
    }
}
