using System;

namespace ForTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            int multi = 1;

            Console.WriteLine("This program will help you with your times tables!");
            Console.Write("Please enter a number: ");
            input = Console.ReadLine();

            if(int.TryParse(input, out num))

            for (int i = 1; i < 16; i++)
                {
                    int ans = multi * num;
                    Console.WriteLine("{0} * {1} is: {2}", multi, num, ans);
                    multi++;
                }


        }
    }
}
