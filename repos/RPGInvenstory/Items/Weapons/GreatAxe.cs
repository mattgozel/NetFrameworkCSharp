using RPGInventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Weapons
{
    public class GreatAxe : Item
    {
        public GreatAxe()
        {
            Name = "A great axe!";
            Description = "Good for chopping down trees and foes alike!";
            Weight = 4;
            Type = ItemType.Weapon;
        }
    }
}
