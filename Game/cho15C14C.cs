using System;
using System.Threading;

namespace Game
{
    public class cho15C14C
    {
        private puzzle1Art pz1 = new puzzle1Art();
        
        public void c1_5_4()
        {
            recho1: ;
            string big1 = Console.ReadLine().ToLower();
            if (big1 == "y")
            {
                string[] dialogY =
                {
                    "[???]  : If you want to get out of this shithole--",
                    "[Guard]: Oi! Shut it!",
                    "[???]  : Piss off you pig!",
                    "[Guard]: You better keep to your self before i beat you!",
                    "[???]  : ...",
                    "[Game] : The guard walks away",
                    "[???]  : Now that he is gone, the way to leave this place is too\n" +
                    "       : Solve the puzzle locking this door...",
                    "[???]  : I'll have to warn you, many have attempted this but none have succeeded...",
                    "[Game] : Do you wish to attempt this challenge? (y/n)",
                };

                int slpT;
                int cntN = 0;

                foreach (var write1 in dialogY)
                {
                    //Adds longer wait for specific dialogs
                    cntN++;
                    if (cntN == 6) {
                        slpT = 4000;
                        Console.ForegroundColor = ConsoleColor.Red;
                    } else if (cntN == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        slpT = 2000;
                    } else {
                        slpT = 2000;
                        Console.ResetColor();
                    }
                    Console.WriteLine(write1);
                    Thread.Sleep(slpT);
                }
                
                recho2:;
                string puz1 = Console.ReadLine().ToLower();

                if (puz1 == "y")
                {
                    // foreach (var )
                    // {
                    //     Console.WriteLine();
                    // }
                    
                    pz1.drawMaze();
                } else if (puz1 == "n")
                {
                    Console.WriteLine("[???] : Well there is only one other way out...\n" +
                                      "        No fight");
                }
                else
                {
                    goto recho2;
                }
            } else if (big1 == "n") {
                Console.WriteLine("[???]: Fine i guess you want to rot in this place \nfor the rest of your time");
            } else if (big1 != "n" || big1 != "y") {
                // Console.WriteLine(
                    // "There was a null or incorrect value\nPlease try again\nErr: 002, Unexpected symbol (check _errList.json for details)");
                goto recho1;
            }
        }
    }
}