using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int x = 0;
        string best = "None";
        foreach (var i in myList)
        {
            if (i.Value >= x)
            {
                x = i.Value;
                best = i.Key;
            }
        }
        return (best);
    }
}
