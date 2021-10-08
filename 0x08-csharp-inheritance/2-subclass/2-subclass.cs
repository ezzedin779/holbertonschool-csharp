using System;

/// <summary>
/// the class obj
/// </summary>
    class Obj
    {
        /// <summary>
        /// are u from base type ?
        /// </summary>
        /// <param name="derivedType">where are u from</param>
        /// <param name="baseType">Tunisia</param>
        /// <returns>bool</returns>
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            return (derivedType.IsSubclassOf(baseType));
        }
    }
