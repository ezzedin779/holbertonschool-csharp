using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < length; i++)
            {
                string space = new String(' ', i);
                Console.Write(space);
                Console.WriteLine("\\");
            }
        }
    }
}
