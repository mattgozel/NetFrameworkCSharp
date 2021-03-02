using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    public class DisplayResults
    {
        public void Display(Result result)
        {
            Console.Clear();
            Console.WriteLine($"Starting Bet: {result.StartingBet:c}");
            Console.WriteLine($"Total Rolls Before Going Broke: {result.TotalRolls}");
            Console.WriteLine($"Highest Amount Won: {result.HighestAmount:c}");
            Console.WriteLine($"Roll Count at Highest Amount Won: {result.RollsAtHigh}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
