using System;

    /// <summary> the class obj <summary>
    class Obj
    {
        /// are u int ?
        public static bool IsOfTypeInt(object obj)
        {
            if (obj is int){
                return(True);
            }
            return (False);
        }
    }
