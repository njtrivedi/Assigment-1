using System;

namespace users
{
    class Program
    {


        static void Main(string[] args)
        {
            //declaring a variable and assigning hex value
            string hex_value = "10FA";

            //converting hex to integer
            int int_value = Convert.ToInt32(hex_value, 16);

            //printing the values
            Console.WriteLine("hex_value = {0}", hex_value);
            Console.WriteLine("int_value = {0}", int_value);

            //hit ENTER to exit
            Console.ReadLine();
        }
    }
}
        
    

