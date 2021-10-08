using System;
using System.Collections.Generic;

    /// <summary> the class obj <summary>
    class Obj
    {
        /// <summary> Are u int ? <summary>
        public static bool IsOfTypeInt(object obj)
        {
            if (obj is int){
                return(True);
            }
            return (False);
        }
    }
