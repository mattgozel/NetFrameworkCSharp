using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I like cheese";

            for (int i = 0; i < str.Length; i++)
            {
                switch(str[i])
                {
                    case 'a' :
                    case 'e' :
                    case 'i' :
                    case 'o' :
                    case 'u' :
                    case 'A' :
                    case 'E' :
                    case 'I' :
                    case 'O' :
                    case 'U' :
                    Console.Write(str[i]);
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
