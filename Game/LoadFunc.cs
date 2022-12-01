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
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = Char.GetNumericValue(d[7]);
                                double classS = bar;
                                Console.WriteLine(classS);
                            }
                        }
                    }
                    string[] savess1 = File.ReadAllLines(timeS[2]);
                    char[] b1 = new char[savess.Length];
                    int savessL1 = 0;
                    savess1.GetLength(savessL1);
                
                    using (StringReader sr1 = new StringReader(savess[1]))
                    {
                        sr1.Read(b1, 0, 9);
                        Console.WriteLine(b1);
                        char[] bs1 = new char[b1.Length];
                        using (StringReader srb = new StringReader(b1[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs1, 0, 1);
                                // Console.WriteLine(bs1);
                                string bss = bs1.ToString();
                                if (bs1 != null)
                                {
                                    int bsn = bs1.Length; 
                                    Debug.Assert(bs1 != null, nameof(bs1) + " != null");
                                    string[] bsss = new[] { bs1[bsn - 1].ToString() };
                                }
                                char[] d = new char[savess.Length];
                                string[] c = new string[] {};

                                using (StringReader srbs = new StringReader(savess[0]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS = bar;
                                    Console.WriteLine(classS);
                                }
                            }
                        }
                    }
                    string[] savess2 = File.ReadAllLines(timeS[2]);
                    char[] b2 = new char[savess2.Length];
                    int savessL2 = 0;
                    savess2.GetLength(savessL2);
                
                    using (StringReader sr2 = new StringReader(savess[2]))
                    {
                        sr2.Read(b2, 0, 9);
                        Console.WriteLine(b2);
                        char[] bs2 = new char[b2.Length];
                        using (StringReader srb = new StringReader(b2[7].ToString()))
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
                                string[] c = new string[] {};

                                using (StringReader srbs = new StringReader(savess[0]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS = bar;
                                    Console.WriteLine(classS);
                                }
                            }
                        }
                    }
                    string[] savess3 = File.ReadAllLines(timeS[2]);
                    char[] b3 = new char[savess3.Length];
                    int savessL3 = 0;
                    savess3.GetLength(savessL3);
                
                    using (StringReader sr3 = new StringReader(savess[3]))
                    {
                        sr3.Read(b3, 0, 9);
                        Console.WriteLine(b3);
                        char[] bs3 = new char[b3.Length];
                        using (StringReader srb = new StringReader(b3[7].ToString()))
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
                                string[] c = new string[] {};

                                using (StringReader srbs = new StringReader(savess[0]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS = bar;
                                    Console.WriteLine(classS);
                                }
                            }
                        }
                    }
                    string[] savess4 = File.ReadAllLines(timeS[2]);
                    char[] b4 = new char[savess4.Length];
                    int savessL4 = 0;
                    savess4.GetLength(savessL4);
                
                    using (StringReader sr4 = new StringReader(savess[4]))
                    {
                        sr4.Read(b4, 0, 9);
                        Console.WriteLine(b4);
                        char[] bs4 = new char[b4.Length];
                        using (StringReader srb = new StringReader(b4[7].ToString()))
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
                                string[] c = new string[] {};

                                using (StringReader srbs = new StringReader(savess[0]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS = bar;
                                    Console.WriteLine(classS);
                                }
                            }
                        }
                    }
                    string[] savess5 = File.ReadAllLines(timeS[5]);
                    char[] b5 = new char[savess5.Length];
                    int savessL5 = 0;
                    savess5.GetLength(savessL5);
                
                    using (StringReader sr5 = new StringReader(savess[5]))
                    {
                        sr5.Read(b5, 0, 9);
                        Console.WriteLine(b5);
                        char[] bs5 = new char[b5.Length];
                        using (StringReader srb = new StringReader(b5[7].ToString()))
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
                                string[] c = new string[] {};

                                using (StringReader srbs = new StringReader(savess[0]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS = bar;
                                    Console.WriteLine(classS);
                                }
                            }
                        }
                    }
                    string[] savess6 = File.ReadAllLines(timeS[2]);
                    char[] b6 = new char[savess6.Length];
                    int savessL6 = 0;
                    savess6.GetLength(savessL6);
                
                    using (StringReader sr6 = new StringReader(savess[6]))
                    {
                        sr6.Read(b6, 0, 9);
                        Console.WriteLine(b6);
                        char[] bs6 = new char[b6.Length];
                        using (StringReader srb = new StringReader(b6[7].ToString()))
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
                                string[] c = new string[] {};

                                using (StringReader srbs = new StringReader(savess[0]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS = bar;
                                    Console.WriteLine(classS);
                                }
                            }
                        }
                    }
                    string[] savess7 = File.ReadAllLines(timeS[2]);
                    char[] b7 = new char[savess7.Length];
                    int savessL7 = 0;
                    savess7.GetLength(savessL7);
                
                    using (StringReader sr7 = new StringReader(savess7[7]))
                    {
                        sr7.Read(b7, 0, 9);
                        Console.WriteLine(b7);
                        char[] bs7 = new char[b7.Length];
                        using (StringReader srb = new StringReader(b7[7].ToString()))
                        {
                            unsafe
                            {
                                srb.Read(bs7, 0, 1);
                                // Console.WriteLine(bs7);
                                string bss = bs7.ToString();
                                if (bs7 != null)
                                {
                                    int bsn = bs7.Length; 
                                    Debug.Assert(bs7 != null, nameof(bs7) + " != null");
                                    string[] bsss = new[] { bs7[bsn - 1].ToString() };
                                }
                                char[] d = new char[savess7.Length];
                                string[] c = new string[] {};

                                using (StringReader srbs = new StringReader(savess7[7]))
                                {
                                    srbs.Read(d, 0, 9);
                                    var bar = Char.GetNumericValue(d[7]);
                                    double classS = bar;
                                    Console.WriteLine(classS);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}