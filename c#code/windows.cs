using System;

namespace new
{
    class P9
{


    static void Main(string[] args)
    {
        string str = "PHP Tutorial";
        Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
    }
}

}

