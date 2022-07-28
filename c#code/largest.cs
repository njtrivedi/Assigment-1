using System;

namespace paper
{
    class Program
    {
        public static void Main()
        {
            int 25,63,10;
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 25 number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  63 number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 10  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (25 >63)
            {
              
           Console.Write("The 25 Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 10 Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 63 Number is the greatest among three \n\n");
            else
                Console.Write("The 25 Number is the greatest among three \n\n");
        }
    }




}
}
