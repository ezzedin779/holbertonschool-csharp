using System;

/// <summary> the class obj </summary>
    class Obj
    {
        /// <summary> Is this and instance of array ? </summary>
        public static bool IsInstanceOfArray(object obj)
        {
            return (typeof(Array).IsInstanceOfType(obj));
        }
    }
