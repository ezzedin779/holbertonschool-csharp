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

        /// <summary>
        /// the Area calcul
        /// </summary>
        /// <returns>the Area</returns>
        public new int Area()
        {
            return (this.height * this.width);
        }

        /// <summary>
        /// Override the ToSTRING
        /// </summary>
        /// <returns>new tostring</returns>
        public override string ToString()
        {
            return string.Format("[{0}] {1} / {2}", this.GetType(), width, height);
        }
    }

    /// <summary>
    /// the child of rectangle the Square
    /// </summary>
    class Square : Rectangle
    {
        private int size;
        
        /// <summary>
        /// get and set the size
        /// </summary>
        /// <value>the correct size</value>
        public int Size
        {
            get {return size;}
            set {
                if (value < 0)
                    throw new ArgumentException("Size must be greater than or equal to 0");
                size = value;
                Height = value;
                Width = value;
            }
        }
    }
