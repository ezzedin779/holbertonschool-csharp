﻿using System;
using System.Collections.Generic;

class  LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int count = 0;
        foreach (var i in myLList)
        {
            if (count == n)
                return (i);
            count++;
        }
        return (0);
    }
}
