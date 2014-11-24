using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    public class Primes
    {
        public long GetPrimes(long num)
        {
            long currentPrime = 0;

            var primeCount = 0;
            var currentNumber = 2;
            do
            {
                bool isPrime = true;
                for (long j = 2; j < currentNumber; j++)
                {
                    if (currentNumber % j == 0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeCount++;
                    currentPrime = currentNumber;
                }
                                currentNumber++;
            }
            while (primeCount < num);

            return currentPrime;
        }
    }
}
