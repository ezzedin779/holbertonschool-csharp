using System;
using System.Collections.Generic;

class  MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        int count2 = 0;
        int index = 0;
        bool s = false;
        bool check = false;
        string first = "";
        foreach (var i in aStack)
        {
            count += 1;
            if (check == false)
            {
                first = i;
                check = true;
            }
            if (i == search)
            {
                s = true;
                index = count;
            }
        }
        if (s == true)
        {
            for (count2 = 0; count2 < index; count2++)
                aStack.Pop();
        }
        aStack.Push(newItem);
        Console.WriteLine("Number of items: {0}", count);
        if (count > 0)
            Console.WriteLine("Top item: {0}", first);
        else
            Console.WriteLine("Stack is empty");
        Console.WriteLine("Stack contains \"{0}\": {1}", search, s);
        return(aStack);
    }
}
