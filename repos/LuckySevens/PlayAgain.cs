using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    public class PlayAgain
    {
        public void Play()
        {
            Console.Clear();
            Console.Write("Would you like to play again? Y/N: ");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "Y":
                    Workflow workflow = new Workflow();
                    workflow.Execute();
                    break;
                default:
                    return;
            }

        }

    }
}
