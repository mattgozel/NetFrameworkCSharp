using System;

namespace YourLifeInMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int dob;

            while(true)
            {
                Console.Write("Please enter the year you were born (ex: 1985): ");
                input = Console.ReadLine();

                if(int.TryParse(input, out dob))
                {
                    if (dob >= 2005)
                    {
                        Console.WriteLine("You are young as hell!");
                        break;
                    }

                    if (dob < 2005 && dob >= 1995)
                    {
                        Console.WriteLine("Did you know that Pixar's 'Up' came out half a decade ago?");
                        break;
                    }

                    if (dob < 1995 && dob >= 1985)
                    {
                        Console.WriteLine("Did you know that Pixar's 'Up' came out half a decade ago?");
                        Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
                        break;
                    }

                    if (dob < 1985 && dob >= 1975)
                    {
                        Console.WriteLine("Did you know that Pixar's 'Up' came out half a decade ago?");
                        Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
                        Console.WriteLine("Also, Space Jam came out not last decade, but the one before THAT.");
                        break;
                    }

                    if (dob < 1975 && dob >= 1965)
                    {
                        Console.WriteLine("Did you know that Pixar's 'Up' came out half a decade ago?");
                        Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
                        Console.WriteLine("Also, Space Jam came out not last decade, but the one before THAT.");
                        Console.WriteLine("Plus the original Jurrasic Park has been around for almost half a century!");
                        break;
                    }

                    if (dob < 1985)
                    {
                        Console.WriteLine("Did you know that Pixar's 'Up' came out half a decade ago?");
                        Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
                        Console.WriteLine("Also, Space Jam came out not last decade, but the one before THAT.");
                        Console.WriteLine("Plus the original Jurrasic Park has been around for almost half a century!");
                        Console.WriteLine("Not to mention that the MASH has been around for almost half a century!");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("You did not enter a valid value.");
                }
            }
        }
    }
}
