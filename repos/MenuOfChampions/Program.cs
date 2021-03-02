using System;

namespace MenuOfChampions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizza, pie, omelet;
            decimal pizzaPrice, piePrice, omeletPrice;

            pizza = "Slice of Big Rico Pizza";
            pie = "Invisible Strawberry Pie";
            omelet = "Denver Omelet";

            pizzaPrice = 500.00m;
            piePrice = 2.00m;
            omeletPrice = 1.50m;

            Console.WriteLine(".oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.");
            Console.WriteLine();
            Console.WriteLine("WELCOME TO HUMBLE'S PLACE!");
            Console.WriteLine("Today's Menu Is...");
            Console.WriteLine();
            Console.WriteLine(".oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.");
            Console.WriteLine();
            Console.WriteLine(pizza + " $ " + pizzaPrice);
            Console.WriteLine(pie + " $ " + piePrice);
            Console.WriteLine(omelet + " $ " + omeletPrice);
        }
    }
}
