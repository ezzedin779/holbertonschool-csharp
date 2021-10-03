using System;
using System.Collections.Generic;

    class Int
    {
        public static void divide(int a, int b)
        {
            int i = 0;
            try
            {
                i = a / b;
            }
            catch (DivideByZeroException)
                {
                    i = 0;
                    Console.WriteLine("Cannot divide by zero");
                }
            finally
            {
                console.WriteLine("{0} / {1} = {2}", a, b, i);
            }
        }
    }
