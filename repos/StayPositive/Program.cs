using System;

namespace StayPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            int loopCounter = 1;

            Console.WriteLine("Please enter a number: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out num))

            while(num >= 0)
                {
                    Console.Write("{0} ", num);
                    num--;
                    loopCounter++;
                    
                    if(loopCounter == 10)
                    {
                        Console.WriteLine("{0} ", num);
                        num--;
                        loopCounter = 1;
                    }
                }
        }
    }
}
