using System;

namespace linux
{
    class P4
    {


        public static void Main()
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
        }
    }
}
    }

