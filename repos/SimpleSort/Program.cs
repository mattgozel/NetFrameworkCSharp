using System;

namespace SimpleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstHalf = { 3, 7, 9, 10, 16, 19, 20, 34, 55, 67, 88, 99 };
            int[] secondHalf = { 1, 4, 8, 11, 15, 18, 21, 44, 54, 79, 89, 100 };

            int[] wholeNumbers = new int[24];
            int temp;

            for (int i = 0; i < firstHalf.Length; i++)
            {
                wholeNumbers[i] = firstHalf[i];
                continue;
            }

            for (int j = 0; j < secondHalf.Length; j++)
            {
                wholeNumbers[j + 12] = secondHalf[j];
                continue;
            }

            for (int l = 1; l < wholeNumbers.Length; l++)
            {
                for (int k = 0; k < wholeNumbers.Length - 1; k++)
                {
                    if (wholeNumbers[k] > wholeNumbers[k + 1])
                    {
                        temp = wholeNumbers[k];
                        wholeNumbers[k] = wholeNumbers[k + 1];
                        wholeNumbers[k + 1] = temp;
                    }
                }
            }
              


            Console.WriteLine("[{0}]", string.Join(", ", wholeNumbers));


        }
    }
}
