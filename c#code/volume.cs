using System;

namespace hello
{
    class Program
    {
        
        {
             public static void Main()
        {
            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                
                n++;
            }

        }
}
