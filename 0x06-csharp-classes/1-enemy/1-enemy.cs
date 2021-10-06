using System;

namespace Enemies
{
    /// <summary>
    /// defines the health only
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
    }
}
