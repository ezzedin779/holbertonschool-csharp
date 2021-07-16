using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine("");
            }
            for(int i = 1; i < length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("_");
        }
    }
}
