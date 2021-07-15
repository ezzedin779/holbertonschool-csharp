using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 89; i++)
            {
                if ((i % 10) > (i / 10))
                {
                    Console.Write("{0:d2}, ", i);
                }
            }
            Console.WriteLine("89");
        }
    }
}
