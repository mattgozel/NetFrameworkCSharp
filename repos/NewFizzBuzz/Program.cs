using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                switch (true)
                {
                    case var fizzBuzz when (i % 3 == 0 && i % 5 == 0):
                        Console.WriteLine("FizzBuzz");
                        break;
                    case var fizz when (i % 3 == 0):
                        Console.WriteLine("Fizz");
                        break;
                    case var buzz when (i % 5 == 0):
                        Console.WriteLine("Buzz");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }
    }
}
