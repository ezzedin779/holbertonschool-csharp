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

    /// <summary>
    /// the child rectangle of shape
    /// </summary>
    class Rectangle : Shape
    {
        private int width;
        private int height;
        
        /// <summary>
        /// init the width
        /// </summary>
        /// <value>the width if not less then 0</value>
        public int Width
        {
            get {return width;}
            set {
                    if (value < 0)
                    {throw new ArgumentException("Width must be greater than or equal to 0");}
                    else
                    {width = value;}
                }
        }

        /// <summary>
        /// init the height
        /// </summary>
        /// <value>the height value if nothing goes wrong</value>
        public int Height
        {
            get {return height;}
            set {
                    if (value < 0)
                    {    throw new ArgumentException("Height must be greater than or equal to 0");}
                    else
                    {height = value;}
                }
        }
    }