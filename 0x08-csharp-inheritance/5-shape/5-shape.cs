using System;

    /// <summary>
        /// The class shape
    /// </summary>
    class Shape
    {
        /// <summary>
        /// Throw an exception
        /// </summary>
        /// <returns>An exception</returns>
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");
        }
    }
