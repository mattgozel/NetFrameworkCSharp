using System;

namespace BirthStones
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int month;

            while(true)
            {
                Console.WriteLine("What month's birthstone are you wanting to know? (Please enter numerical value of month. ex: July = 7");
                input = Console.ReadLine();

                if (int.TryParse(input, out month))
                {
                    if (month == 1)
                    {
                        Console.WriteLine("January - Garnet");
                        break;
                    }

                    if (month == 2)
                    {
                        Console.WriteLine("February - Amethyst");
                        break;
                    }

                    if (month == 3)
                    {
                        Console.WriteLine("March - Aquamarine");
                        break;
                    }

                    if (month == 4)
                    {
                        Console.WriteLine("April - Diamond");
                        break;
                    }

                    if (month == 5)
                    {
                        Console.WriteLine("May - Emerald");
                        break;
                    }

                    if (month == 6)
                    {
                        Console.WriteLine("June - Pearl");
                        break;
                    }

                    if (month == 7)
                    {
                        Console.WriteLine("July - Ruby");
                        break;
                    }

                    if (month == 8)
                    {
                        Console.WriteLine("August - Peridot");
                        break;
                    }

                    if (month == 9)
                    {
                        Console.WriteLine("September - Sapphire");
                        break;
                    }

                    if (month == 10)
                    {
                        Console.WriteLine("October - Opal");
                        break;
                    }

                    if (month == 11)
                    {
                        Console.WriteLine("November - Topaz");
                        break;
                    }

                    if (month == 12)
                    {
                        Console.WriteLine("December - Turquoise");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a number 1-12");
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter a number, please try again.");
                    continue;
                }
            }
        }
    }
}
