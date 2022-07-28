using System;

namespace configure
{
    class P3
    {



        static void Main(string[] args)
        {

            int= 32;
            int= 62;
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
        }
    }
}

