using System;
using System.Runtime.InteropServices;
using System.Xml;
/* #
             * #  ┏   -   -   -   -   -   -   -   -   ┓
             * #  |   .   .   .   .   .   .   .   .   |
             * #  |   .   .   .   .   .   .   .   .   |
             * #  |   .   .   .   .   .   .   .   .   |
             * #  |   .   .   .   .   .   .   .   .   |
             * #  |   .   .   .   .   .   .   .   .   |
             * #  |   .   .   .   .   .   .   .   .   |
             * #  |   .   .   .   .   .   .   .   .   |
             * #  |   .   .   .   .   .   .   .   .   |
             * #  ┗   -   -   -   -   -   -   -   -   ┛
             * #
             * #  --KEY--
             * #  Grid size 10 x 10
             * #  "." = movable space
             * #  "|" = 
             * #  "┓" = 
             * #  "┛" = 
             * #  "┏" = 
             * #  "┗" = 
             * #  "-" = wall
             * #  -- Leave a "TAB" or "   " space in-between each element on the x axis
             * #  -- Use "#" to save as a comment in the maze.txt file.
             */



namespace Game
{
    public class mazeBuilder
    {
        void mazebuilder()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Time to build a maze!");
            Console.ResetColor();
            Console.WriteLine("How large would you like the maze to be?" +
                              "\n (3-15 X 3-15)" +
                              "\n Type the x distance first");
            xtry: ;
            string mazeSizex = Console.ReadLine();
            

            bool IsDigitsOnly()
            {
                foreach (char c in mazeSizex)
                {
                    if (c < '0' || c > '9')
                        return false;
                }

                return true;
            }
            if (mazeSizex == null)
            {
                Console.WriteLine("The x val was null please try again...");
                goto xtry;
            } else if (!IsDigitsOnly())
            {
                Console.WriteLine("Please try again there were unexpected chars in that string");
                goto xtry;
            } 
            
            int mazeSizexi = Int32.Parse(mazeSizex);
            
            if (mazeSizexi > 15 || mazeSizexi < 3)
            {
                Console.WriteLine("The maze size was too big try again");
                goto xtry;
            }
            
            
        }
    }
}