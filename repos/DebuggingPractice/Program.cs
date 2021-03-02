using System;

namespace DebuggingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 1, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"The number at index {i} is {numbers[i]}.");
            }
        }
    }
}
