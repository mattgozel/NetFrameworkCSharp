using System;

namespace FruitSalad
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruit = { "Kiwi Fruit", "Gala Apple", "Granny Smith Apple", "Cherry Tomato", "Gooseberry", "Beefsteak Tomato", "Braeburn Apple", "Blueberry", "Strawberry", "Navel Orange", "Pink Pearl Apple", "Raspberry", "Blood Orange", "Sungold Tomato", "Fuji Apple", "Blackberry", "Banana", "Pineapple", "Florida Orange", "Kiku Apple", "Mango", "Satsuma Orange", "Watermelon", "Snozzberry" };
            String[] fruitSalad = new string[12];

            int apple = 0;
            int orange = 0;
            int fruitCount = 0;

            for (int i=0; i < fruit.Length; i++)
            {
                if (fruit[i].Contains("berry"))
                {
                    fruitSalad[fruitCount] = fruit[i];
                    fruitCount++;
                }

                else if (fruit[i].Contains("Apple") && apple < 3)
                {
                    fruitSalad[fruitCount] = fruit[i];
                    apple++;
                    fruitCount++;
                }

                else if (fruit[i].Contains("Orange") && orange < 2)
                {
                    fruitSalad[fruitCount] = fruit[i];
                    orange++;
                    fruitCount++;
                }

                if (fruitCount == 12)
                {
                    break;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", fruitSalad));
        }
    }
}
