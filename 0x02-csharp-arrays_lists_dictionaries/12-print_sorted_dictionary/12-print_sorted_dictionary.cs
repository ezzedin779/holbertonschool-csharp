using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> Ls = new List<string>();
        foreach (var K in myDict)
            Ls.Add(K.Key);
        Ls.Sort();
        foreach (var i in Ls)
            Console.WriteLine("{0}: {1}", i, myDict[i]);
    }
}
