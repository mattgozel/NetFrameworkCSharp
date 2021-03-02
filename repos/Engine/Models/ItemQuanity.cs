using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuanity
    {
        public int ItemID { get; set; }
        public int Quanity { get; set; }

        public ItemQuanity(int itemID, int quanity)
        {
            ItemID = itemID;
            Quanity = quanity;
        }
    }
}
