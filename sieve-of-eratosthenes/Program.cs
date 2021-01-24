using System;

namespace sieve_of_eratosthenes
{
    class Program
    {
        public static void SieveOfEratosthenes(int n)
        {

            // Create a boolean array
            bool[] prime = new bool[n + 1];

            // Initialize all entries it as true.
            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed,
                // then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

   
            // Print all prime numbers
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }
        }

        // Main
        public static void Main()
        {
            Console.Write("Type a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers between 1 and " + n + " are:");
            // Call the function
            SieveOfEratosthenes(n);
        }
    }
}
