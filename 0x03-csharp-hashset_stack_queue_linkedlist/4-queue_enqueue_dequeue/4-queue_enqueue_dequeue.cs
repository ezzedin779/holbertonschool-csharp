using System;
using System.Collections.Generic;

class  MyQueue
{
   public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)

    {
        int count = 0;
        int count2 = 0;
        int index = 0;
        bool s = false;
        bool check = false;
        string first = "";
        foreach (var i in aQueue)
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
                aQueue.Dequeue();
        }
        aQueue.Enqueue(newItem);
        Console.WriteLine("Number of items: {0}", count);
        if (count > 0)
            Console.WriteLine("First item: {0}", first);
        else
            Console.WriteLine("Queue is empty");
        Console.WriteLine("Queue contains \"{0}\": {1}", search, s);
        return(aQueue);
    }
}
