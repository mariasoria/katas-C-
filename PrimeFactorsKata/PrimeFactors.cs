using System.Collections.Generic;

namespace PrimFactorsKata
{
    public class PrimeFactors
    {
        public static List<int> generate(int number)
        {
            var primes = new List<int>();
            var primeOption = 2;
            while (hasStillPrimeFactors(number))
            {
                while (aPrimeFactorIsFound(number, primeOption))
                {
                    primes.Add(primeOption);
                    number /= primeOption;
                }

                primeOption++;
            }
            return primes;
        }

        private static bool aPrimeFactorIsFound(int number, int primeOption)
        {
            return number % primeOption == 0;
        }

        private static bool hasStillPrimeFactors(int number)
        {
            return number > 1;
        }
    }
}

