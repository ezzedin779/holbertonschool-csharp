using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            int i = number;
            if (number < 0)
            {
                i = i * -1;
            }
            Console.Write("{0}", i % 10);
        }
    }
}
