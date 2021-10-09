using System;
using System.Collections.Generic;
using System.Reflection;
/// <summary>
/// the class obj 
/// </summary>

    class Obj
    {
        /// <summary>
        /// check who is this myobj
        /// </summary>
        /// <param name="myObj">the object to check</param>
        public static void Print(object myObj)
        {
            TypeInfo t = myObj.GetType().GetTypeInfo();
            IEnumerable<PropertyInfo> pro = t.GetProperties();
            IEnumerable<MethodInfo> me = t.GetMethods();
            Console.WriteLine(t.Name + " Properties:");
            foreach(PropertyInfo i in pro)
                Console.WriteLine(i.Name);
            Console.WriteLine(t.Name + " Methods:");
            foreach (MethodInfo x in me)
                Console.WriteLine(x.Name);
        }
    }
