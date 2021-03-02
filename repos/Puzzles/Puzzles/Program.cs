using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            Console.WriteLine("Write something...");
            input = Console.ReadLine();

            if(input.Length >= 3)
            {
                string yt = input.Substring(1, 2);

                if(yt == "yt")
                {
                    string ytRemoved = input.Remove(1, 2);
                    Console.WriteLine(ytRemoved);
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
            else
            {
                Console.WriteLine(input);
            }

        }
    }
}
