using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        if (myDict.ContainsKey(key) == false)
            return (myDict);
        myDict.Remove(key);
        return (myDict);
    }
}
