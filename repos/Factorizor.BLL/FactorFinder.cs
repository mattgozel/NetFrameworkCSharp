using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    public class FactorFinder
    {
        public string FactorSender(int number)
        {
            StringBuilder sb = new StringBuilder();
            string factorContainer;

            for (int i = number; i > 0; i--)
            {
                if (number % i == 0)
                {
                    sb.Append(i.ToString()).Append(", ");
                }
            }

            factorContainer = sb.ToString();
            return factorContainer;
        }
    }

    public class PerfectChecker
    {
        public bool IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = number - 1; i > 0; i--)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

        public class PrimeChecker
        {
            public bool IsPrimeNumber(int number)
            {
            
                int sum = 0;

                for (int i = number - 1; i > 1; i--)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == 0 && number != 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
        }
}
