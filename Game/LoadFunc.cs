using System.IO;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Game
{
    public class LoadFunc
    {
        CharCreation cC = new CharCreation();
        private writeVars wV = new writeVars();
        
        int numF = 1;
        public string[] saves = new string[]
        {
            ""
        };
        
        public void loadSave()
        {
            //Gets the files in the saves dir
            foreach(string file in Directory.GetFiles(@"C:\\Users\\Public\\DatabladeSaves\\"))
            // foreach (string file in Directory.GetFiles(@"C:\\Users\\Finley\\Documents\\DataBladeSaves\\"))
            {
                //Lists all of the files to console 
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
                //debug -- Lists contents of the save file
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

        private void setValues()
        {
            cC.Class = (byte)wV.classS1;
            
            cC.visAtt[1] = wV.headS1;
            cC.visAtt[0] = wV.torsoS1;
            cC.visAtt[2] = wV.armsS1;
            cC.visAtt[3] = wV.legsS1;
            cC.visAtt[4] = wV.handsS1;
            cC.visAtt[5] = wV.feetS1;

            Console.WriteLine("---Final vals---");
            Console.WriteLine(cC.Class);
            
            byte repVisAtS = 0;
            while (repVisAtS != 6)
            {
                repVisAtS++;
                Console.WriteLine(cC.visAtt[repVisAtS - 1]);
            }
        }
        
        //Recent save loading
        
        public void recentSave()
        {
            Console.WriteLine("Loading most recent save...");
            foreach(string file in Directory.GetFiles(@"C:\\Users\\Public\\DatabladeSaves\\"))
                // foreach (string file in Directory.GetFiles(@"C:\\Users\\Finley\\Documents\\DataBladeSaves\\"))
            {
                //gets most recent save
                
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
                
                string[] timeS = { "", "" };
                int sc = 0;
                if (saves.Length > 1) //Function for most recent save 
                {
                    int amtS = saves.Length;
                    Console.WriteLine(amtS -2);
                    while (amtS != 0)
                    {
                        // Console.WriteLine(saves[amtS -1]);
                        timeS = timeS.Concat(new String[] { saves[amtS -1] }).ToArray();
                        int timeSL = timeS.Length - 1;
                        Console.WriteLine(timeS[timeSL] + " (" + timeSL + ")");
                        amtS--;
                        sc = 1;
                    }
                    //Outputs here
                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(timeS[2] + "      // This is the most recent save");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                }
                else
                {
                    goto ASDa;}
                ASDa: ;
                string[] savess = File.ReadAllLines(timeS[2]);
                char[] b = new char[savess.Length];
                int savessL = 0;
                savess.GetLength(savessL);
                
                //Loads class

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
                            // Console.WriteLine(bs);
                            string bss = bs.ToString();
                            if (bs != null)
                            {
                                int bsn = bs.Length;
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                            }

                            char[] d = new char[savess.Length];
                            string[] c = new string[] { };

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = Char.GetNumericValue(d[7]);
                                double classS = bar;
                                wV.classS1 = classS;
                            }
                        }
                    }

                    //Loads Head

                    using (StringReader sr1 = new StringReader(savess[1]))
                    {
                        sr1.Read(b, 0, 9);
                        Console.WriteLine(b);
                        char[] bs2 = new char[b.Length];
                        using (StringReader srb = new StringReader(b[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs2, 0, 1);
                                // Console.WriteLine(bs2);
                                string bss = bs2.ToString();
                                if (bs2 != null)
                                {
                                    int bsn = bs2.Length;
                                    Debug.Assert(bs2 != null, nameof(bs2) + " != null");
                                    string[] bsss = new[] { bs2[bsn - 1].ToString() };
                                }

                                char[] d = new char[savess.Length];
                                string[] c = new string[] { };

                                using (StringReader srbs = new StringReader(savess[1]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS1 = bar;
                                    wV.headS1 = classS1;
                                }
                            }
                        }
                    }

                    //Loads Torso

                    using (StringReader sr2 = new StringReader(savess[2]))
                    {
                        sr2.Read(b, 0, 9);
                        Console.WriteLine(b);
                        char[] bs2 = new char[b.Length];
                        using (StringReader srb = new StringReader(b[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs2, 0, 1);
                                // Console.WriteLine(bs2);
                                string bss = bs2.ToString();
                                if (bs2 != null)
                                {
                                    int bsn = bs2.Length;
                                    Debug.Assert(bs2 != null, nameof(bs2) + " != null");
                                    string[] bsss = new[] { bs2[bsn - 1].ToString() };
                                }

                                char[] d = new char[savess.Length];
                                string[] c = new string[] { };

                                using (StringReader srbs = new StringReader(savess[2]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS2 = bar;
                                    wV.torsoS1 = classS2;
                                }
                            }
                        }
                    }

                    //Loads Arms

                    using (StringReader sr3 = new StringReader(savess[3]))
                    {
                        sr3.Read(b, 0, 9);
                        Console.WriteLine(b);
                        char[] bs3 = new char[b.Length];
                        using (StringReader srb = new StringReader(b[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs3, 0, 1);
                                // Console.WriteLine(bs3);
                                string bss = bs3.ToString();
                                if (bs != null)
                                {
                                    int bsn = bs3.Length;
                                    Debug.Assert(bs3 != null, nameof(bs3) + " != null");
                                    string[] bsss = new[] { bs3[bsn - 1].ToString() };
                                }

                                char[] d = new char[savess.Length];
                                string[] c = new string[] { };

                                using (StringReader srbs = new StringReader(savess[3]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS3 = bar;
                                    wV.armsS1 = classS3;
                                }
                            }
                        }
                    }

                    //Loads Legs

                    using (StringReader sr4 = new StringReader(savess[4]))
                    {
                        sr4.Read(b, 0, 9);
                        Console.WriteLine(b);
                        char[] bs4 = new char[b.Length];
                        using (StringReader srb = new StringReader(b[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs4, 0, 1);
                                // Console.WriteLine(bs4);
                                string bss = bs4.ToString();
                                if (bs4 != null)
                                {
                                    int bsn = bs4.Length;
                                    Debug.Assert(bs4 != null, nameof(bs4) + " != null");
                                    string[] bsss = new[] { bs4[bsn - 1].ToString() };
                                }

                                char[] d = new char[savess.Length];
                                string[] c = new string[] { };

                                using (StringReader srbs = new StringReader(savess[4]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS4 = bar;
                                    wV.legsS1 = classS4;
                                }
                            }
                        }
                    }

                    //Loads Hands

                    using (StringReader sr5 = new StringReader(savess[5]))
                    {
                        sr5.Read(b, 0, 9);
                        Console.WriteLine(b);
                        char[] bs5 = new char[b.Length];
                        using (StringReader srb = new StringReader(b[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs5, 0, 1);
                                // Console.WriteLine(bs5);
                                string bss = bs5.ToString();
                                if (bs5 != null)
                                {
                                    int bsn = bs5.Length;
                                    Debug.Assert(bs5 != null, nameof(bs5) + " != null");
                                    string[] bsss = new[] { bs5[bsn - 1].ToString() };
                                }

                                char[] d = new char[savess.Length];
                                string[] c = new string[] { };

                                using (StringReader srbs = new StringReader(savess[5]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS5 = bar;
                                    wV.handsS1 = classS5;
                                }
                            }
                        }
                    }

                    //Loads Feet

                    using (StringReader sr6 = new StringReader(savess[6]))
                    {
                        sr6.Read(b, 0, 9);
                        Console.WriteLine(b);
                        char[] bs6 = new char[b.Length];
                        using (StringReader srb = new StringReader(b[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs6, 0, 1);
                                // Console.WriteLine(bs6);
                                string bss = bs6.ToString();
                                if (bs6 != null)
                                {
                                    int bsn = bs6.Length;
                                    Debug.Assert(bs6 != null, nameof(bs6) + " != null");
                                    string[] bsss = new[] { bs6[bsn - 1].ToString() };
                                }

                                char[] d = new char[savess.Length];
                                string[] c = new string[] { };

                                using (StringReader srbs = new StringReader(savess[6]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS6 = bar;
                                    wV.feetS1 = classS6;
                                }
                            }
                        }
                    }
                }

                setValues();
            }
        }
    }
}