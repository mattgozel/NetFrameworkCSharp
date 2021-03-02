using System;

namespace ForByFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.Write("|");

                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                }

                for (int x = 0; x < 1; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        Console.Write("$");
                    }
                    Console.Write("|");
                }

                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < 1; i++)
            {
                Console.Write("|");

                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("@");
                    }
                    Console.Write("|");
                }

                for (int x = 0; x < 1; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        Console.Write("#");
                    }
                    Console.Write("|");
                }

                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("@");
                    }
                    Console.Write("|");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < 1; i++)
            {
                Console.Write("|");

                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                }

                for (int x = 0; x < 1; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        Console.Write("$");
                    }
                    Console.Write("|");
                }

                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                }
                Console.WriteLine("");
            }
        }
    }
}
