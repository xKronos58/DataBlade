using System;
using System.Collections.Specialized;

namespace Game
{
    public class puzzle1Art
    {
        public int wallTile = 1;

        public int floorTile = 0;

        //player location
        
        public static int playerX;
        public static int playerY;
        
        public int[] playerPos =
        {
            playerX,
            playerY
        };
        
        //These are place holders until i move onto graphics.
        public string walls1 = "==========";
        public string walls2 = "|";
        public string floor1 = " ";
        public string player1 = "O";
        public string exit = "X";

        public string[,] maze1 = new String[10, 6];
        
        public void drawMaze()
        {
            //Writes maze

            int line1 = 0;

            while (line1 != 10)
            {
                maze1[line1, 0] = "=";
                maze1[line1, 5] = "=";
                line1++;
            }
            
            int wFloorS = 1;
            
            while (wFloorS != 9)
            {
                maze1[wFloorS, 1] = " ";
                maze1[wFloorS, 2] = " ";
                maze1[wFloorS, 3] = " ";
                maze1[wFloorS, 4] = " ";
                wFloorS++;
            }
            
            maze1[0, 1] = "|"; maze1[0, 2] = "|"; maze1[0, 3] = "|"; maze1[0, 4] = "|";
            maze1[9, 1] = "|"; maze1[9, 2] = "|"; maze1[9, 3] = "|"; maze1[9, 4] = "|";

            maze1[0, 1] = "X";
            //Maze Size 10 x 6

            /*
             * ⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
             * 🔩⬛⬛⬛⬛⬛⬛⬛⬛⬜
             * ⬜⬛⬛⬛⬛⬛⬛⬛⬛⬜
             * ⬜⬛⬛⬛⬛⬛⬛⬛⬛⬜
             * ⬜⬛⬛⬛⬛⬛⬛🙃⬛⬜
             * ⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
             */

            Console.WriteLine(
            );
            playerX = 8;
            playerY = 4;

            Console.WriteLine("[???] : Head to that vent over there\n" +
                              " and then you can find the puzzle on the other side of the wall");
            Console.ForegroundColor = ConsoleColor.Green;
            while (playerX != 1 || playerY != 1)
            {
                pzl1();
            }

            Console.WriteLine("[Game]: Now that you have learnt how to move\n" +
                              "        lets get on to the real puzzle");
        }

        public void pzl1()
        {
            Console.Clear();
            byte printM = 0;
            while (printM != 6)
            {
                Console.WriteLine(maze1[0, printM]  + maze1[1, printM]  + maze1[2, printM]  + maze1[3, printM]
                                  + maze1[4, printM] + maze1[5, printM] + maze1[6, printM] + maze1[7, printM]
                                  + maze1[8, printM] + maze1[9, printM]
                    );
                printM++;
            }
            
            Console.WriteLine("[Game]: Which way do you want to go (w/a/s/d)");

            int choicenum = 0;

            choicenum++;
            uxk: ;
            string Go = Console.ReadLine().ToLower();

            maze1[playerX, playerY] = " ";
            
            switch (Go)
            {
                //Checks which direction the player moved and 
                //then changes the pos of the player
                case "w":
                    playerY += 4;
                    if (playerY > 1)
                    {
                        playerY = 1;
                    }
                    else if (playerY < 9)
                    {
                        playerY = 9;
                    }
                    break;
                case "a":
                    playerX += 4;
                    if (playerX > 1)
                    {
                        playerX = 1;
                    }
                    else if (playerX < 9)
                    {
                        playerX = 9;
                    }
                    break;
                case "s":
                    playerY -= 4;
                    if (playerY > 1)
                    {
                        playerY = 1;
                    }
                    else if (playerY < 4)
                    {
                        playerY = 4;
                    }
                    break;
                case "d":
                    playerX -= 4;
                    if (playerX < 1)
                    {
                        playerX = 1;
                    }
                    else if (playerX > 9)
                    {
                        playerX = 9;
                    }
                    break;
                default:
                    Console.WriteLine("UnexpectedKey: err 002");
                    goto uxk;
            }
            
            maze1[playerX, playerY] = "O"; 

            // Console.WriteLine(playerPos[0] + "\n" + playerPos[1]); Needs fixing
            // Console.WriteLine("================");
            // Console.WriteLine(playerX + "\n" + playerY);
            // This was for debugging reasons   
            
            //Key: 0 = floor, 1 = wall, 2 = player, 3 = exit, 4 = item; 
            
            int[,] puzzle1 = new int[10, 6];

            int lineWall = 0;
            
            //Writes walls to int array
            
            while (lineWall != 10)
            {
                puzzle1[lineWall, 0] = 1;
                puzzle1[lineWall, 5] = 1;
                lineWall++;
            }
            
            //Writes floor to int array

            int wFloor = 1;
            
            while (wFloor != 9)
            {
                puzzle1[wFloor, 1] = 0;
                puzzle1[wFloor, 2] = 0;
                puzzle1[wFloor, 3] = 0;
                puzzle1[wFloor, 4] = 0;
                wFloor++;
            }
            
            //Writes side walls
            
            puzzle1[0, 1] = 1; puzzle1[0, 2] = 1; puzzle1[0, 3] = 1; puzzle1[0, 4] = 1;
            puzzle1[9, 1] = 1; puzzle1[9, 2] = 1; puzzle1[9, 3] = 1; puzzle1[9, 4] = 1;
            
            //Writes Exit

            puzzle1[0, 1] = 3;
            
            //Writes player pos
            
            if (playerX != 0 && playerY != 0 && playerX != 10 && playerY != 5)
            {
                puzzle1[playerX, playerY] = 2;
            }

            int outBinaryMaze = 0;

            // while (outBinaryMaze != 10)
            // {
            //     Console.WriteLine(puzzle1[outBinaryMaze, 0] + ",");
            //     Console.WriteLine(puzzle1[outBinaryMaze, 1] + ",");
            //     Console.WriteLine(puzzle1[outBinaryMaze, 2] + ",");
            //     Console.WriteLine(puzzle1[outBinaryMaze, 3] + ",");
            //     Console.WriteLine(puzzle1[outBinaryMaze, 4] + ",");
            //     Console.WriteLine(puzzle1[outBinaryMaze, 5] + ",");
            //     Console.WriteLine("\n");
            //     outBinaryMaze++;
            // }
            Console.WriteLine("X: " + playerX + ", Y: " + playerY);
        }
    }
}