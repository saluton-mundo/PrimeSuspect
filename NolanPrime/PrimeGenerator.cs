using System;
using System.Collections.Generic;

namespace NolanPrime
{
    public class PrimeGenerator
    {
        public List<int> Generate(int n)
        {
            List<int> primes = new List<int>(n);
            primes.Add(2);      // 1 is not a prime
            int nextPrime = 3;  // 3 is the next possible prime

            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                
                bool isPrime = true;

                for (int i = 0; primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                
                nextPrime += 2;
            }
            
            return primes;
        }
    }
}
