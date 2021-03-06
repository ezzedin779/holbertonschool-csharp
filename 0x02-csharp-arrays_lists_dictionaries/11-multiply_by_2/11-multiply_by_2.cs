using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> d in myDict)
            newDict.Add(d.Key, d.Value * 2);
        return (newDict);
    }
}
