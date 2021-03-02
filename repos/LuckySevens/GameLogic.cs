using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    public class GameLogic
    {
        public Result ActualGameLogic(int bet)
        {
            int totalRolls = 0;
            int highestAmount = bet;
            int rollsAtHigh = 0;

            Result result = new Result();
            RollDice rollDice = new RollDice();

            result.StartingBet = bet;

            while(bet > 0)
            {
                int diceOne = rollDice.Roll();
                int diceTwo = rollDice.Roll();
                totalRolls++;

                if (diceOne + diceTwo == 7)
                {
                    bet = bet + 4;
                }

                if (diceOne + diceTwo != 7)
                {
                    bet = bet - 1;
                }

                if (bet > highestAmount)
                {
                    highestAmount = bet;
                    rollsAtHigh = totalRolls;
                }
            }

            result.TotalRolls = totalRolls;
            result.HighestAmount = highestAmount;
            result.RollsAtHigh = rollsAtHigh;

            return result;
        }
    }
}
