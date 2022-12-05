// using System.IO;
// using System;
// using System.Linq;
//
// namespace Game
// {
//     public class attemptedCharConversion
//     {
//         private char[] d;
//         private string[] saves = new string[]
//         {
//             ""
//         };
//         
//         string[] timeS = { "", "" };
//             
//             
//             if (saves.Length > 1) //Function for most recent save 
//             {
//             int amtS = saves.Length;
//             Console.WriteLine(amtS -2);
//             while (amtS != 0)
//                  {
//                 // Console.WriteLine(saves[amtS -1]);
//                 timeS = timeS.Concat(new String[] { saves[amtS -1] }).ToArray();
//                 int timeSL = timeS.Length - 1;
//                 Console.WriteLine(timeS[timeSL] + " (" + timeSL + ")");
//                 amtS--;
//                 var sc = 1;
//                 }   
//             //Outputs here
//             Console.WriteLine("------------------------------------------------------------------------------------------------------");
//             Console.WriteLine(timeS[2] + "      // This is the most recent save");
//             Console.WriteLine("------------------------------------------------------------------------------------------------------");
//         }
//         
//         string[] savess = File.ReadAllLines(timeS[2]);
//             using (StringReader sr = saves[4])
//         {
//             
//         }
//     }
// }

