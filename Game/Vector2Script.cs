using System;

namespace Game
{
    /// <summary>
    /// Stores the vector2 positions of the player (x, y) in that format
    /// </summary>
    public class Vector2
    {
        
        public float x { get; set; }
        
        public float y { get; set; }
        
        public Vector2()
        {
            x = zero().x;
            y = zero().y;
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// Returns x & y as 0
        /// </summary>
        /// <returns></returns>
        public static Vector2 zero()
        {
            return new Vector2(0, 0);
        }

    }
}
