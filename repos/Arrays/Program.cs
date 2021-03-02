using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 7, 2, 4, 7, 12 };
            int sum = 0;
            int min = nums[0];
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (nums[i] < min)
                {
                    min = nums[i];
                }

                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            Console.WriteLine($"The sum of the numbers in the array is: {sum}");
            Console.WriteLine($"The smallest number in the array is: {min}");
            Console.WriteLine($"The largest number in the array is: {max}");
        }
    }
}
