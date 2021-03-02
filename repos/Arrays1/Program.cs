using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 7, 2, 4, 7, 12 };
            int temp;
            bool check;

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }

                if (check = false)
                {
                    break;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }
    }
}
