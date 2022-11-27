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
                            //Trys to parse to a string /!\ This is the part that is broken /!\ 
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            // Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                // Console.WriteLine(bsss);
                            }
                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                // Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                // Console.WriteLine(c);
                                char foo = '2';
                                int bar = CharUnicodeInfo.GetDecimalDigitValue(d[0]);
                                // int bar = d[0] - '0';
                                // int bar14 = bar - 14;
                                if (bar == 19) {
                                    Console.WriteLine("the value was 19");
                                    Console.WriteLine("Err: 004, something went wrong.... ¯\\_(ツ)_/¯ (Refer to _errList.json)");
                                } else {
                                    Console.WriteLine(bar);
                                }
                                int len = d.Length;
                                int arn = 0;
                                // while (len != 0)
                                // {
                                //     len--;
                                //     Console.WriteLine(d[arn]);
                                //     arn++;
                                // }
                                {
                                    
                                }
                            }
                        }
                    }
                }
                string[] savess1 = File.ReadAllLines(timeS[2]);
                char[] b1 = new char[savess.Length];
                int savessL1 = 0;
                savess.GetLength(savessL);
                
                using (StringReader sr = new StringReader(savess[1]))
                {
                    sr.Read(b1, 0, 9);
                    Console.WriteLine(b1);
                    char[] bs = new char[b.Length];
                    using (StringReader srb = new StringReader(b1[7].ToString()))
                    {
                        unsafe
                        {
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            // Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                // Console.WriteLine(bsss);
                            }
                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                // Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                // Console.WriteLine(c);
                                char foo = '2';
                                int bar = CharUnicodeInfo.GetDecimalDigitValue(d[0]);
                                // int bar = d[0] - '0';
                                // int bar14 = bar - 14;
                                if (bar == 19) {
                                    Console.WriteLine("the value was 19");
                                    Console.WriteLine("Err: 004, something went wrong.... ¯\\_(ツ)_/¯ (Refer to _errList.json)");
                                } else {
                                    Console.WriteLine(bar);
                                }
                                int len = d.Length;
                                int arn = 0;
                                // while (len != 0)
                                // {
                                //     len--;
                                //     Console.WriteLine(d[arn]);
                                //     arn++;
                                // }
                                {
                                    
                                }
                            }
                        }
                    }
                }
                string[] savess2 = File.ReadAllLines(timeS[2]);
                char[] b2 = new char[savess.Length];
                int savessL2 = 0;
                savess.GetLength(savessL);
                
                using (StringReader sr = new StringReader(savess[2]))
                {
                    sr.Read(b2, 0, 9);
                    Console.WriteLine(b2);
                    char[] bs = new char[b2.Length];
                    using (StringReader srb = new StringReader(b2[7].ToString()))
                    {
                        unsafe
                        {
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            // Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                // Console.WriteLine(bsss);
                            }
                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                // Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                // Console.WriteLine(c);
                                char foo = '2';
                                int bar = CharUnicodeInfo.GetDecimalDigitValue(d[0]);
                                // int bar = d[0] - '0';
                                // int bar14 = bar - 14;
                                if (bar == 19) {
                                    Console.WriteLine("the value was 19");
                                    Console.WriteLine("Err: 004, something went wrong.... ¯\\_(ツ)_/¯ (Refer to _errList.json)");
                                } else {
                                    Console.WriteLine(bar);
                                }
                                int len = d.Length;
                                int arn = 0;
                                // while (len != 0)
                                // {
                                //     len--;
                                //     Console.WriteLine(d[arn]);
                                //     arn++;
                                // }
                                {
                                    
                                }
                            }
                        }
                    }
                }
                string[] savess3 = File.ReadAllLines(timeS[2]);
                char[] b3 = new char[savess.Length];
                int savessL3 = 0;
                savess.GetLength(savessL);
                
                using (StringReader sr = new StringReader(savess[3]))
                {
                    sr.Read(b3, 0, 9);
                    Console.WriteLine(b3);
                    char[] bs = new char[b3.Length];
                    using (StringReader srb = new StringReader(b3[7].ToString()))
                    {
                        unsafe
                        {
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            // Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                // Console.WriteLine(bsss);
                            }
                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                // Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                // Console.WriteLine(c);
                                char foo = '2';
                                int bar = CharUnicodeInfo.GetDecimalDigitValue(d[0]);
                                // int bar = d[0] - '0';
                                // int bar14 = bar - 14;
                                if (bar == 19) {
                                    Console.WriteLine("the value was 19");
                                    Console.WriteLine("Err: 004, something went wrong.... ¯\\_(ツ)_/¯ (Refer to _errList.json)");
                                } else {
                                    Console.WriteLine(bar);
                                }
                                int len = d.Length;
                                int arn = 0;
                                // while (len != 0)
                                // {
                                //     len--;
                                //     Console.WriteLine(d[arn]);
                                //     arn++;
                                // }
                                {
                                    
                                }
                            }
                        }
                    }
                }
                string[] savess4 = File.ReadAllLines(timeS[2]);
                char[] b4 = new char[savess.Length];
                int savessL4 = 0;
                savess.GetLength(savessL);
                
                using (StringReader sr = new StringReader(savess[4]))
                {
                    sr.Read(b4, 0, 9);
                    Console.WriteLine(b4);
                    char[] bs = new char[b4.Length];
                    using (StringReader srb = new StringReader(b4[7].ToString()))
                    {
                        unsafe
                        {
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            // Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                // Console.WriteLine(bsss);
                            }
                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                // Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                // Console.WriteLine(c);
                                char foo = '2';
                                int bar = CharUnicodeInfo.GetDecimalDigitValue(d[0]);
                                // int bar = d[0] - '0';
                                // int bar14 = bar - 14;
                                if (bar == 19) {
                                    Console.WriteLine("the value was 19");
                                    Console.WriteLine("Err: 004, something went wrong.... ¯\\_(ツ)_/¯ (Refer to _errList.json)");
                                } else {
                                    Console.WriteLine(bar);
                                }
                                int len = d.Length;
                                int arn = 0;
                                // while (len != 0)
                                // {
                                //     len--;
                                //     Console.WriteLine(d[arn]);
                                //     arn++;
                                // }
                                {
                                    
                                }
                            }
                        }
                    }
                }
                string[] savess5 = File.ReadAllLines(timeS[2]);
                char[] b5 = new char[savess.Length];
                int savessL5 = 0;
                savess.GetLength(savessL);
                
                using (StringReader sr = new StringReader(savess[5]))
                {
                    sr.Read(b5, 0, 9);
                    Console.WriteLine(b5);
                    char[] bs = new char[b5.Length];
                    using (StringReader srb = new StringReader(b5[7].ToString()))
                    {
                        unsafe
                        {
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            // Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                // Console.WriteLine(bsss);
                            }
                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                // Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                // Console.WriteLine(c);
                                char foo = '2';
                                int bar = CharUnicodeInfo.GetDecimalDigitValue(d[0]);
                                // int bar = d[0] - '0';
                                // int bar14 = bar - 14;
                                if (bar == 19) {
                                    Console.WriteLine("the value was 19");
                                    Console.WriteLine("Err: 004, something went wrong.... ¯\\_(ツ)_/¯ (Refer to _errList.json)");
                                } else {
                                    Console.WriteLine(bar);
                                }
                                int len = d.Length;
                                int arn = 0;
                                // while (len != 0)
                                // {
                                //     len--;
                                //     Console.WriteLine(d[arn]);
                                //     arn++;
                                // }
                                {
                                    
                                }
                            }
                        }
                    }
                }
                string[] savess6 = File.ReadAllLines(timeS[2]);
                char[] b6 = new char[savess.Length];
                int savessL6 = 0;
                savess.GetLength(savessL);
                
                using (StringReader sr = new StringReader(savess[6]))
                {
                    sr.Read(b6, 0, 9);
                    Console.WriteLine(b6);
                    char[] bs = new char[b6.Length];
                    using (StringReader srb = new StringReader(b6[7].ToString()))
                    {
                        unsafe
                        {
                            srb.Read(bs, 0, 1);
                            Console.WriteLine(bs);
                            string bss = bs.ToString();
                            // string[] bss = new[] { bs.ToString() };
                            // int bsi = Int32.Parse(bss[0]);
                            // Console.WriteLine(bss);
                            if (bs != null)
                            {
                                int bsn = bs.Length; 
                                Debug.Assert(bs != null, nameof(bs) + " != null");
                                string[] bsss = new[] { bs[bsn - 1].ToString() };
                                // Console.WriteLine(bsss);
                            }
                            char[] d = new char[savess.Length];
                            string[] c = new string[] {};

                            using (StringReader srbs = new StringReader(savess[0]))
                            {
                                srbs.Read(d, 0, 9);
                                // Console.WriteLine();
                                c = c.Concat(new String[] { d.ToString() }).ToArray();
                                // Console.WriteLine(c);
                                char foo = '2';
                                int bar = CharUnicodeInfo.GetDecimalDigitValue(d[0]);
                                //I also tried 
                                // int bar = d[0] - '0';
                                // int bar14 = bar - 14;
                                if (bar == 19) {
                                    Console.WriteLine("the value was 19");
                                    Console.WriteLine("Err: 004, something went wrong.... ¯\\_(ツ)_/¯ (Refer to _errList.json)");
                                } else {
                                    Console.WriteLine(bar);
                                    //Currently outputs -1
                                }
                                int len = d.Length;
                                int arn = 0;
                                // while (len != 0)
                                // {
                                //     len--;
                                //     Console.WriteLine(d[arn]);
                                //     arn++;
                                // }
                                {
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}