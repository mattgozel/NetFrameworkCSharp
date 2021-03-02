using System;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Alex";
            int p = 1;

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.Write(firstName.Substring(0, p));
                p++;
            }
        }
    }
}
