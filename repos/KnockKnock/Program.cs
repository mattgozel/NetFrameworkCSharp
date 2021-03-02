using System;

namespace KnockKnock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knock Knock! Guess who!! ");
            String nameGuess = Console.ReadLine();

            if (nameGuess == "Marty McFly")
            {
                Console.WriteLine("Hey! That's right! I'm back!");
                Console.WriteLine(".... from the Future."); // Sorry, had to!
            }
            else
            {
                Console.WriteLine("Dude, do I -look- like " + nameGuess);
                
            }
        }
    }
}
