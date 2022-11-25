using System.IO;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Game
{
    public class LoadFunc
    {
        CharCreation cC = new CharCreation();
        
        int numF = 1;
        public string[] saves = new string[]
        {
            ""
        };
        
        public void loadSave()
        {
            foreach(string file in Directory.GetFiles(@"C:\\Users\\Public\\DatabladeSaves\\"))
            // foreach (string file in Directory.GetFiles(@"C:\\Users\\Finley\\Documents\\DataBladeSaves\\"))
            {
                Console.WriteLine("(" + numF + ") " + file);
                numF++;
                saves = saves.Concat(new String[] { file }).ToArray();
                // Console.WriteLine(saves[numF]);
            }
            Console.WriteLine("Which save do you want to chose?");
            incrtValS: ;
            string sc = Console.ReadLine();
            int sci = Int32.Parse(sc);
            if (sci == -1 || sci == null)
            {
                Console.WriteLine("The value of sci is: " + sci);
                Console.WriteLine("There was a null or incorrect value" +
                                  "\nPlease try again" +
                                  "\nErr: 002, Unexpected symbol (check _errList.json for details)");
                goto incrtValS;
            } else if (sci != -1)
            {
                string[] savess = File.ReadAllLines(saves[sci]);
                Console.WriteLine(savess[0]);
                Console.WriteLine(savess[1]);
                Console.WriteLine(savess[2]);
                Console.WriteLine(savess[3]);
                Console.WriteLine(savess[4]);
                Console.WriteLine(savess[5]);
                Console.WriteLine(savess[6]);
                Console.WriteLine(savess[7]);
                Console.WriteLine(savess[8]);
            }
        }
        
        
        
        //Recent save loading
        
        
        public void recentSave()
        {
            Console.WriteLine("Loading most recent save...");
            foreach(string file in Directory.GetFiles(@"C:\\Users\\Public\\DatabladeSaves\\"))
                // foreach (string file in Directory.GetFiles(@"C:\\Users\\Finley\\Documents\\DataBladeSaves\\"))
            {
                // Console.WriteLine("(" + numF + ") " + file);
                numF++;
                saves = saves.Concat(new String[] { file }).ToArray();
                // Console.WriteLine(saves[numF]);
            }
            if (numF == -1)
            {
                Console.WriteLine("Err: 003, Out of bounds expectation (Refer to _errList.json)");
            } else if (numF == 0)
            {
                Console.WriteLine("You do not have any saves please start a new game");
            } else
            {
                int sc = 1;
                string[] savess = File.ReadAllLines(saves[sc]);
                char[] b = new char[savess.Length];
                int savessL = 0;
                savess.GetLength(savessL);
                
                using (StringReader sr = new StringReader(savess[0]))
                {
                    sr.Read(b, 0, 9);
                    Console.WriteLine(b);
                    char[] bs = new char[b.Length];
                    using (StringReader srb = new StringReader(b[7].ToString()))
                    {
                        unsafe
                        {
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                Console.WriteLine(bsss);
                            }

                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                Console.WriteLine(c);
                            }
                        }
                    }
                }
                cC.visAtt[0] = 1;
            }
        }
    }
}