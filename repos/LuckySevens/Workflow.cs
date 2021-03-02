using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    public class Workflow
    {
        public void Execute()
        {
            StartingMenu menu = new StartingMenu();
            menu.Menu();
            
            GetIntFromUser getInt = new GetIntFromUser();
            int userInt = getInt.GetInt();

            GameLogic logic = new GameLogic();
            Result result = logic.ActualGameLogic(userInt);

            DisplayResults displayResults = new DisplayResults();
            displayResults.Display(result);

            PlayAgain playAgain = new PlayAgain();
            playAgain.Play();
        }
    }
}
