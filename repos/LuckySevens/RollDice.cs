using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    public class RollDice
    {
        public Random randomNumber = new Random();
        public int Roll()
        {
            return randomNumber.Next(1, 7);
        }
    }
}
