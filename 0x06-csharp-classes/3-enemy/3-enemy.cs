using System;

namespace Enemies
{
    /// <summary>
    /// Enemy Class :o 
    /// </summary>
    class Zombie
    {
        /// private field
        private int health;
        
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
        
        /// tell me how much health u have ?
        public int GetHealth()
        {
            return (health);
        }
    }
}
