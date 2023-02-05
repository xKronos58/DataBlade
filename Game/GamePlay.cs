using System;
using System.Collections.Specialized;
using System.Threading;

namespace Game
{
    public class GamePlay
    {
        //Initializes the required Vector2()'s.
        private static readonly Vector2 BoardSize = new Vector2(10, 10);
        private static Vector2 _exit = new Vector2(1, 2);
        private Vector2 _playerPos = new Vector2(BoardSize.x, BoardSize.y);
        private Vector2 key1 = new Vector2((int)BoardSize.x, (int)BoardSize.y);
        private Vector2 spikes = new Vector2((int)BoardSize.x, (int)BoardSize.y);
        
        public void Game()
        {
            string[] dialogY =
            {
                //TODO Change the dialog... please
                "[???]  : Hey.... i see you just got thrown in here...",
                "[???]  : If you want to get out of this shit-hole--",
                "[Guard]: Oi! Shut it!",
                "[???]  : Piss off you pig!",
                "[Guard]: You better keep to your self before i beat you!",
                "[???]  : ...",
                "[Game] : The guard walks away",
                "[???]  : Now that he is gone, the way to leave this place is too\n" +
                "       : Solve the puzzle locking this door...",
                "[???]  : I'll have to warn you, many have attempted this but none have succeeded...",
            };

            int slpT;
            int cntN = 0;

            foreach (string element in dialogY)
            {
                //Adds longer wait for specific dialogs
                cntN++;
                if (cntN == 2)
                {
                    slpT = 400;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (cntN == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    slpT = 200;
                }
                else
                {
                    slpT = 200;
                    Console.ResetColor();
                }

                Console.WriteLine(element);
                Thread.Sleep(slpT);
            }

            int[,] board = new int[(int)BoardSize.x, (int)BoardSize.y];
            string[,] boardAscii = new string[(int)BoardSize.x + 2, (int)BoardSize.y + 1];
            
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
             * #  Grid size 10 x 10     | Dev. Notes:       -B = IntCode;
             * #  "." = movable space   | Wall   (B) = 1
             * #  "|" =                 | Player (B) = 2
             * #  "┓" =                 | Key    (B) = 3
             * #  "┛" =                 | Exit   (B) = 4
             * #  "┏" =                 | Collect(B) = 5
             * #  "┗" =                 | 
             * #  "-" = wall            |
             * #  "O" = player          |
             * #  -- Leave a "TAB" or "   " space in-between each element on the x axis
             * #  -- Use "#" to save as a comment in the maze.txt file.
             * #
             */
            
            //
            _playerPos.x -= 2;
            _playerPos.y -= 2;
            board[(int)_playerPos.x -1, (int)_playerPos.y -1] = 2;

            int i = (int)BoardSize.x;
            int i2 = (int)BoardSize.y;
            
            //Writes all the wall
            while (i != 0)
            {
                board[i -1, 0] = 1;
                board[i -1, (int)BoardSize.y -1] = 1;
                i--;
            }
            while (i2 != 0)
            {
                board[0, i2 -1] = 1;
                board[(int)BoardSize.x -1, i2 -1] = 1;
                i2--;
            }

            //Writes The exit and the player to the array
            board[(int)_exit.x, (int)_exit.y] = 3; 
            board[(int)_playerPos.x -1, (int)_playerPos.y -1] = 2;

            //Checks if the Board[x, y] = wall, and if they are then it will not 
            // allow the player to move there.
            var canMoveUp = board[(int)_playerPos.x -1, (int)_playerPos.y - 2] != 1;
            var canMoveDown = board[(int)_playerPos.x -1, (int)_playerPos.y] != 1;
            var canMoveLeft = board[(int)_playerPos.x - 2, (int)_playerPos.y - 1] != 1;
            var canMoveRight = board[(int)_playerPos.x, (int)_playerPos.y - 1] != 1;
            
            string[] boardvala =
            {
                "   ", //0
                "|||", //1
                "[0]", //2
                "< >", //3
                "XXX", //4
                "???", //5
                "^^^", //6
                "--K"  //7
            };

            //Movement
            while ((int)_playerPos.x != (int)_exit.x || (int)_playerPos.y != (int)_exit.y)
            {
                board[(int)_playerPos.x, (int)_playerPos.y] = 0;
                
                //Called everytime the wile loop is executed, reads the key
                ConsoleKeyInfo keyListener = Console.ReadKey();

                if ((int)_playerPos.x == 1 && (int)_playerPos.x == 1)
                {
                    canMoveDown = true;
                    canMoveRight = true;
                }
                
                //Checks what key was pressed
                if (keyListener.Key == ConsoleKey.W && canMoveUp) { //Moves up
                    Console.Clear();
                    _playerPos.y -= 1;
                } else if (keyListener.Key == ConsoleKey.A && canMoveLeft) { //Moves Right
                    Console.Clear();
                    _playerPos.x -= 1;
                } else if (keyListener.Key == ConsoleKey.S && canMoveDown) { //Moves Down
                    Console.Clear();
                    _playerPos.y += 1;
                } else if (keyListener.Key == ConsoleKey.D && canMoveRight) { //Moves Left
                    Console.Clear();
                    _playerPos.x += 1;
                }
                Console.Clear();
                //ReWrites the player
                board[(int)_playerPos.x, (int)_playerPos.y] = 2;
                
                //Writes what is happening on the board to the string of Board[].
                int o = (int)BoardSize.x -1;
                int o2 = (int)BoardSize.y -1;
                while (o != -1)
                {
                    while (o2 != -1)
                    {
                        switch (board[o, o2])
                        {
                            case 0: //If the board is 0 it is movable space
                                boardAscii[o, o2] = boardvala[0];
                                break;
                            case 1: //If the board is 0 it is wall
                                boardAscii[o, o2] = boardvala[1];
                                break;
                            case 2: //If the board is 0 it is player
                                boardAscii[o, o2] = boardvala[2];
                                break;
                            case 3: //If the board is 0 it is exit
                                boardAscii[o, o2] = boardvala[3];
                                break;
                            case 4: //If the board is 0 it is unseeable space
                                boardAscii[o, o2] = boardvala[4];
                                break;
                            case 5: //?? -- Idk y this is included...
                                boardAscii[o, o2] = boardvala[5];
                                break;
                            case 6: //If the board is 6 it is spikes
                                boardAscii[o, o2] = boardvala[6];
                                break;
                            case 7: //If the board is 7 it is a key
                                boardAscii[o, o2] = boardvala[7];
                                break;
                        }

                        o2--;
                    }
                    
                    boardAscii[(int)BoardSize.x + 1, (int)BoardSize.y] = 
                        "Use W,A,S and D to move around"; 

                    o2 = (int)BoardSize.y -1;
                    o--;
                }
                //Writes the Board[] string array to the console everytime
                // a key is pressed
                
                int asd = 0;
                foreach (string a in boardAscii)
                {
                    Console.WriteLine(boardAscii[0, asd] + boardAscii[1, asd] + 
                                      boardAscii[2, asd] + boardAscii[3, asd] + 
                                      boardAscii[4, asd] + boardAscii[5, asd] + 
                                      boardAscii[6, asd] + boardAscii[7, asd] + 
                                      boardAscii[8, asd] + boardAscii[9, asd]);
                    if (asd == 9)
                    {
                        break;
                    }
                    asd++;
                }

                //Checks if the Board[x, y] = wall, and if they are then it will not 
                // allow the player to move there.
                // -1 == current pos, 0 == 1 to the bottom or right, -2 == one up or to the left
                canMoveUp = board[(int)_playerPos.x - 1, (int)_playerPos.y - 1] != 1;
                canMoveDown = board[(int)_playerPos.x - 1, (int)_playerPos.y + 1] != 1;
                canMoveLeft = board[(int)_playerPos.x - 1, (int)_playerPos.y] != 1;
                canMoveRight = board[(int)_playerPos.x + 1, (int)_playerPos.y - 1] != 1;
                
                //Writes the player pos below the board so the player can see what their
                // position is at all times.
                Console.WriteLine("x: " + _playerPos.x + ", y: " + _playerPos.y);
            }

            Console.WriteLine("You exited the first room, now time for the second room");

            bool key1Collected = false;
            
            //Remakes the board for the next level
            BoardSize.x = 15;
            BoardSize.y = 7;
            
            _playerPos.x = BoardSize.x;
            _playerPos.y = BoardSize.y;

            _exit.x = 1;
            _exit.y = 1;
            
            _playerPos.x -= 2;
            _playerPos.y -= 2;
            
            spikes.y = _exit.y - 1;

            key1.x = _exit.x;
            key1.y = _exit.y + 2;

            //resizes the board for the new board size.
            board = new int[(int)BoardSize.x, (int)BoardSize.y];
            boardAscii = new string[(int)BoardSize.x + 1, (int)BoardSize.y + 1];
            board[(int)spikes.x, (int)spikes.y] = 6;
            board[(int)key1.x -1, (int)key1.y -1] = 7;
            board[(int)_playerPos.x -1, (int)_playerPos.y -1] = 2;

            int i3 = (int)BoardSize.x;
            int i4 = (int)BoardSize.y;
            
            //Writes all the wall
            while (i3 != 0)
            {
                board[i3 -1, 0] = 1;
                board[i3 -1, (int)BoardSize.y -1] = 1;
                i3--;
            }
            while (i4 != 0)
            {
                board[0, i4 -1] = 1;
                board[(int)BoardSize.x -1, i4 -1] = 1;
                i4--;
            }

            //Writes The exit and the player to the array
            board[(int)_exit.x, (int)_exit.y] = 3; 
            board[(int)_playerPos.x -1, (int)_playerPos.y -1] = 2;

            while ((int)_playerPos.x != (int)_exit.x || 
                   (int)_playerPos.y != (int)_exit.y && key1Collected)
            {
                board[(int)_playerPos.x, (int)_playerPos.y] = 0;

                //Called everytime the wile loop is executed, reads the key
                ConsoleKeyInfo keyListener = Console.ReadKey();

                //Checks what key was pressed
                if (keyListener.Key == ConsoleKey.W && canMoveUp)
                {
                    //Moves up
                    Console.Clear();
                    _playerPos.y -= 1;
                }
                else if (keyListener.Key == ConsoleKey.A && canMoveLeft)
                {
                    //Moves Right
                    Console.Clear();
                    _playerPos.x -= 1;
                }
                else if (keyListener.Key == ConsoleKey.S && canMoveDown)
                {
                    //Moves Down
                    Console.Clear();
                    _playerPos.y += 1;
                }
                else if (keyListener.Key == ConsoleKey.D && canMoveRight)
                {
                    //Moves Left
                    Console.Clear();
                    _playerPos.x += 1;
                }
                
                //ReWrites the player
                board[(int)_playerPos.x, (int)_playerPos.y] = 2;
                
                Console.Clear();

                //Writes what is happening on the board to the string of Board[].
                int o = (int)BoardSize.x - 1;
                int o2 = (int)BoardSize.y - 1;
                while (o != -1)
                {
                    while (o2 != -1)
                    {
                        switch (board[o, o2])
                        {
                            case 0: //If the board is 0 it is movable space
                                boardAscii[o, o2] = boardvala[0];
                                break;
                            case 1: //If the board is 0 it is wall
                                boardAscii[o, o2] = boardvala[1];
                                break;
                            case 2: //If the board is 0 it is player
                                boardAscii[o, o2] = boardvala[2];
                                break;
                            case 3: //If the board is 0 it is exit
                                boardAscii[o, o2] = boardvala[3];
                                break;
                            case 4: //If the board is 0 it is unseeable space
                                boardAscii[o, o2] = boardvala[4];
                                break;
                            case 5: //?? -- Idk y this is included...
                                boardAscii[o, o2] = boardvala[5];
                                break;
                            case 6: //If the board is 6 it is spikes
                                boardAscii[o, o2] = boardvala[6];
                                break;
                            case 7: //If the board is 7 it is a key
                                boardAscii[o, o2] = boardvala[7];
                                break;
                        }

                        o2--;
                    }
                    
                    boardAscii[(int)BoardSize.x - 1, (int)BoardSize.y] = 
                        "||| Dodge ^^ as they are spikes, make sure to collect the key! (--k)"; 
                    
                    o2 = (int)BoardSize.y -1;
                    o--;
                }

                if ((int)_playerPos.x == (int)key1.x && (int)_playerPos.y == (int)key1.y)
                {
                    key1Collected = true;
                }
                
                int asd = 0;
                foreach (string a in boardAscii)
                {
                    if (asd == 8)
                    {
                        break;
                    }
                    
                    Console.WriteLine(boardAscii[0, asd] + boardAscii[1, asd] +
                                      boardAscii[2, asd] + boardAscii[3, asd] +
                                      boardAscii[4, asd] + boardAscii[5, asd] +
                                      boardAscii[6, asd] + boardAscii[7, asd] +
                                      boardAscii[8, asd] + boardAscii[9, asd] +
                                      boardAscii[10, asd] + boardAscii[11, asd]+
                                      boardAscii[12, asd] + boardAscii[13, asd] + 
                                      boardAscii[14, asd]);

                    asd++;

                    //Checks if the Board[x, y] = wall, and if they are then it will not 
                    // allow the player to move there.
                    // -1 == current pos, 0 == 1 to the bottom or right, -2 == one up or to the left
                    canMoveUp = board[(int)_playerPos.x - 1, (int)_playerPos.y - 1] != 1;
                    canMoveDown = board[(int)_playerPos.x - 1, (int)_playerPos.y + 1] != 1;
                    canMoveLeft = board[(int)_playerPos.x - 1, (int)_playerPos.y] != 1;
                    canMoveRight = board[(int)_playerPos.x + 1, (int)_playerPos.y - 1] != 1;
                }

                //Writes the player pos below the board so the player can see what their
                // position is at all times.
                Console.WriteLine("x: " + _playerPos.x + ", y: " + _playerPos.y);

            }
        }
    }
}