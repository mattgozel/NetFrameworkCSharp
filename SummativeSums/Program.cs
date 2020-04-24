using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Program
    {
        static int Summer(int[] x)
        {
            int sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] array2 = new int[] { 999, -60, -77, 14, 160, 301 };
            int[] array3 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };
            int sum1;
            int sum2;
            int sum3;
            
            sum1 = Summer(array1);
            sum2 = Summer(array2);
            sum3 = Summer(array3);

            Console.WriteLine($"#1 Array Sum: {sum1}");
            Console.WriteLine($"#2 Array Sum: {sum2}");
            Console.WriteLine($"#3 Array Sum: {sum3}");
            Console.ReadLine();
        }
    }
}
