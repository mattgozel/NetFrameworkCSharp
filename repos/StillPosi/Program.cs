﻿using System;

namespace StillPosi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Still Posi!");

            int[] numbers = { 389, -447, 26, -485, 712, -884, 94, -64, 868, -776, 227, -744, 422, -109, 259, -500, 278, -219, 799, -311 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }
        }
    }
}
