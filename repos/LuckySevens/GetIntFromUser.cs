using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    public class GetIntFromUser
    {
        public int GetInt()
        {
            while (true)
            {
                Console.Clear();
                int bet;
                Console.Write("Please enter your starting bet: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out bet) == false)
                {
                    Console.WriteLine("Please enter a valid number...");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                if (bet <= 0)
                {
                    Console.WriteLine("Bet must be greater than $0...");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                return bet;
            }
        }
    }
}
