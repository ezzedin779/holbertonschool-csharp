using System;

namespace Enemies
{
    /// <summary>
    /// Enemy Class :o 
    /// </summary>
    class Zombie
    {
        /// public field
        public int? health {get; set;} = null;
        
        /// initialize to 0
        public Zombie()
        {
            this.health = 0;
        }

        /// a value for health ?
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
