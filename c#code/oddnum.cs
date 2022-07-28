using System;

namespace public
{
    class p1
{
    static void Main(String[]args
    {
        Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
        for (int n = 1; n < (99 + 1); n++)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine(n.ToString());
            }
        }

    }




