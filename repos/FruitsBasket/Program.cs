using System;

namespace FruitsBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruit = { "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Apple", "Orange", "Apple", "Apple", "Orange", "Orange", "Apple", "Apple", "Apple", "Apple", "Orange", "Orange", "Apple", "Apple", "Orange", "Orange", "Orange", "Orange", "Apple", "Apple", "Apple", "Apple", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Apple", "Orange", "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Orange" };
            int orange = 0;
            int apple = 0;
            int try1 = 0;
            int try2 = 0;

            for (int i = 0; i < fruit.Length; i++)
            {
                if (fruit[i] == "Orange")
                {
                    orange++;
                }
                else
                {
                    apple++;
                }
            }

            String[] oranges = new String[33];
            String[] apples = new String[28];

            for (int j = 0; j < fruit.Length; j++)
            {
                if (fruit[j] == "Orange")
                {
                    oranges[try1] = fruit[j];
                    try1++;
                }
                else
                {
                    apples[try2] = fruit[j];
                    try2++;
                }
            }

            int result = fruit.GetLength(0);
            int result1 = oranges.GetLength(0);
            int result2 = apples.GetLength(0);
            
            Console.WriteLine("Total Fruit: {0}", result);
            Console.WriteLine("Oranges: {0}", result1);
            Console.WriteLine("Apples: {0}", result2);
        }
    }
}
