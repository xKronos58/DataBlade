using System;

namespace Game
{
    public class puzzle1Art
    {
        public string[] walkableTile =
        {
            "⬛",
            "⬛"
        };

        public string[] wallTile =
        {
            "⬜",
            "⬜"
        };

        public string player = "🙃";

        public string door = "🚪";

        public string vent = "🔩";

        public string cash = "💵";

        public void drawMaze()
        {
            //Maze Size 10 x 10
            
            /*
             * ⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
             * 🔩⬛⬛⬛⬛⬛⬛⬛⬛⬜
             * ⬜⬛⬛⬛⬛⬛⬛⬛⬛⬜
             * ⬜⬛⬛⬛⬛⬛⬛⬛⬛⬜
             * ⬜⬛⬛⬛⬛⬛⬛🙃⬛⬜
             * ⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
             */
            
            
            //row 1
            Console.WriteLine(wallTile[0] + wallTile[0] + wallTile[0]
                              + wallTile[0] + wallTile[0]
                              + wallTile[0] + wallTile[0]
                              + wallTile[0] + wallTile[0]
                              + wallTile[0]);
            
            //row 2
            Console.WriteLine(vent + walkableTile[0] + walkableTile[0]
                              + walkableTile[0] + walkableTile[0]
                              + walkableTile[0] + walkableTile[0]
                              + walkableTile[0] + walkableTile[0]
                              + wallTile[0]);
            
            
        }
    }
}