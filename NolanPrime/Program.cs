using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NolanPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool outputPrimesUnordered = false; // Set this to true if you would like to output every prime (unordered)
            bool outputPrimesOrdered = false;   // Set this to true if you would like to output every prime (ordered)

            Stopwatch timer = new Stopwatch();
         
            Console.WriteLine(string.Format("{0}:\t\tStarting prime generation...", timer.Elapsed.ToString()));

            var n = 1000000;

            timer.Start();

            var primes = new PrimeGenerator().Generate(n);

            timer.Stop();

            #region Verbose Output Options
            if(outputPrimesUnordered)
            {
                Parallel.ForEach(primes, (prime) =>
                {
                    Console.WriteLine(prime);
                });
            }

            if(outputPrimesOrdered)
            {
                foreach (var prime in primes)
                {
                    Console.WriteLine(prime);
                }
            }
            #endregion

            Console.WriteLine(string.Format("{0}:\tFinished generating primes...", timer.Elapsed.ToString()));
            Console.WriteLine(string.Format("{0}:\t{1}th prime is {2}...", timer.Elapsed.ToString(), n, primes.Last()));
            Console.ReadKey();
        }
    }
}
