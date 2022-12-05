using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Game
{
    public class LoadFunc
    {
        private readonly CharCreation cC = new CharCreation();

        private int numF = 1;

        public string[] saves =
        {
            ""
        };

        private readonly writeVars wV = new writeVars();

        //Manual save loading choice (WIP)
        public void loadSave()
        {
            //Gets the files in the saves dir
            foreach (var file in Directory.GetFiles(@"C:\\Users\\Public\\DatabladeSaves\\"))
                // foreach (string file in Directory.GetFiles(@"C:\\Users\\Finley\\Documents\\DataBladeSaves\\"))
            {
                //Lists all of the files to console 
                Console.WriteLine("(" + numF + ") " + file);
                numF++;
                saves = saves.Concat(new[] { file }).ToArray();
                // Console.WriteLine(saves[numF]);
            }

            Console.WriteLine("Which save do you want to chose?");
            incrtValS: ;
            var sc = Console.ReadLine();
            var sci = int.Parse(sc);
            if (sci == -1 || sci == null)
            {
                Console.WriteLine("The value of sci is: " + sci);
                Console.WriteLine("There was a null or incorrect value" +
                                  "\nPlease try again" +
                                  "\nErr: 002, Unexpected symbol (check _errList.json for details)");
                goto incrtValS;
            }

            if (sci != -1)
            {
                var savess = File.ReadAllLines(saves[sci]);
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

        //Sets the save values into the cC.visAtts[x];

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
            foreach (var file in Directory.GetFiles(@"C:\\Users\\Public\\DatabladeSaves\\"))
                // foreach (string file in Directory.GetFiles(@"C:\\Users\\Finley\\Documents\\DataBladeSaves\\"))
            {
                //gets most recent save

                // Console.WriteLine("(" + numF + ") " + file);
                numF++;
                saves = saves.Concat(new[] { file }).ToArray();
                // Console.WriteLine(saves[numF]);
            }

            if (numF == -1)
            {
                Console.WriteLine("Err: 003, Out of bounds expectation (Refer to _errList.json)");
            }
            else if (numF == 0)
            {
                Console.WriteLine("You do not have any saves please start a new game");
            }
            else
            {
                string[] timeS = { "", "" };
                var sc = 0;
                if (saves.Length > 1) //Function for most recent save 
                {
                    var amtS = saves.Length;
                    Console.WriteLine(amtS - 2);
                    while (amtS != 0)
                    {
                        // Console.WriteLine(saves[amtS -1]);
                        timeS = timeS.Concat(new[] { saves[amtS - 1] }).ToArray();
                        var timeSL = timeS.Length - 1;
                        Console.WriteLine(timeS[timeSL] + " (" + timeSL + ")");
                        amtS--;
                        sc = 1;
                    }

                    //Outputs here
                    Console.WriteLine(
                        "------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(timeS[2] + "      // This is the most recent save");
                    Console.WriteLine(
                        "------------------------------------------------------------------------------------------------------");
                }

                var savess = File.ReadAllLines(timeS[2]);
                var b = new char[savess.Length];
                var savessL = 0;
                savess.GetLength(savessL);

                //Loads class

                using (var sr = new StringReader(savess[0]))
                {
                    sr.Read(b, 0, 9);
                    Console.WriteLine(b);
                    var bs = new char[b.Length];
                    using (var srb = new StringReader(b[7].ToString()))
                    {
                        srb.Read(bs, 0, 1);
                        // Console.WriteLine(bs);
                        var bss = bs.ToString();
                        if (bs != null)
                        {
                            var bsn = bs.Length;
                            Debug.Assert(bs != null, nameof(bs) + " != null");
                            string[] bsss = { bs[bsn - 1].ToString() };
                        }

                        var d = new char[savess.Length];
                        string[] c = { };

                        using (var srbs = new StringReader(savess[0]))
                        {
                            srbs.Read(d, 0, 9);
                            var bar = char.GetNumericValue(d[7]);
                            var classS = bar;
                            wV.classS1 = classS;
                        }
                    }

                    //Loads Head

                    using (var sr1 = new StringReader(savess[1]))
                    {
                        sr1.Read(b, 0, 9);
                        Console.WriteLine(b);
                        var bs2 = new char[b.Length];
                        using (var srb = new StringReader(b[7].ToString()))
                        {
                            srb.Read(bs2, 0, 1);
                            // Console.WriteLine(bs2);
                            var bss = bs2.ToString();
                            if (bs2 != null)
                            {
                                var bsn = bs2.Length;
                                Debug.Assert(bs2 != null, nameof(bs2) + " != null");
                                string[] bsss = { bs2[bsn - 1].ToString() };
                            }

                            var d = new char[savess.Length];
                            string[] c = { };

                            using (var srbs = new StringReader(savess[1]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = char.GetNumericValue(d[7]);
                                var classS1 = bar;
                                wV.headS1 = classS1;
                            }
                        }
                    }

                    //Loads Torso

                    using (var sr2 = new StringReader(savess[2]))
                    {
                        sr2.Read(b, 0, 9);
                        Console.WriteLine(b);
                        var bs2 = new char[b.Length];
                        using (var srb = new StringReader(b[7].ToString()))
                        {
                            srb.Read(bs2, 0, 1);
                            // Console.WriteLine(bs2);
                            var bss = bs2.ToString();
                            if (bs2 != null)
                            {
                                var bsn = bs2.Length;
                                Debug.Assert(bs2 != null, nameof(bs2) + " != null");
                                string[] bsss = { bs2[bsn - 1].ToString() };
                            }

                            var d = new char[savess.Length];
                            string[] c = { };

                            using (var srbs = new StringReader(savess[2]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = char.GetNumericValue(d[7]);
                                var classS2 = bar;
                                wV.torsoS1 = classS2;
                            }
                        }
                    }

                    //Loads Arms

                    using (var sr3 = new StringReader(savess[3]))
                    {
                        sr3.Read(b, 0, 9);
                        Console.WriteLine(b);
                        var bs3 = new char[b.Length];
                        using (var srb = new StringReader(b[7].ToString()))
                        {
                            srb.Read(bs3, 0, 1);
                            // Console.WriteLine(bs3);
                            var bss = bs3.ToString();
                            if (bs != null)
                            {
                                var bsn = bs3.Length;
                                Debug.Assert(bs3 != null, nameof(bs3) + " != null");
                                string[] bsss = { bs3[bsn - 1].ToString() };
                            }

                            var d = new char[savess.Length];
                            string[] c = { };

                            using (var srbs = new StringReader(savess[3]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = char.GetNumericValue(d[7]);
                                var classS3 = bar;
                                wV.armsS1 = classS3;
                            }
                        }
                    }

                    //Loads Legs

                    using (var sr4 = new StringReader(savess[4]))
                    {
                        sr4.Read(b, 0, 9);
                        Console.WriteLine(b);
                        var bs4 = new char[b.Length];
                        using (var srb = new StringReader(b[7].ToString()))
                        {
                            srb.Read(bs4, 0, 1);
                            // Console.WriteLine(bs4);
                            var bss = bs4.ToString();
                            if (bs4 != null)
                            {
                                var bsn = bs4.Length;
                                Debug.Assert(bs4 != null, nameof(bs4) + " != null");
                                string[] bsss = { bs4[bsn - 1].ToString() };
                            }

                            var d = new char[savess.Length];
                            string[] c = { };

                            using (var srbs = new StringReader(savess[4]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = char.GetNumericValue(d[7]);
                                var classS4 = bar;
                                wV.legsS1 = classS4;
                            }
                        }
                    }

                    //Loads Hands

                    using (var sr5 = new StringReader(savess[5]))
                    {
                        sr5.Read(b, 0, 9);
                        Console.WriteLine(b);
                        var bs5 = new char[b.Length];
                        using (var srb = new StringReader(b[7].ToString()))
                        {
                            srb.Read(bs5, 0, 1);
                            // Console.WriteLine(bs5);
                            var bss = bs5.ToString();
                            if (bs5 != null)
                            {
                                var bsn = bs5.Length;
                                Debug.Assert(bs5 != null, nameof(bs5) + " != null");
                                string[] bsss = { bs5[bsn - 1].ToString() };
                            }

                            var d = new char[savess.Length];
                            string[] c = { };

                            using (var srbs = new StringReader(savess[5]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = char.GetNumericValue(d[7]);
                                var classS5 = bar;
                                wV.handsS1 = classS5;
                            }
                        }
                    }

                    //Loads Feet

                    using (var sr6 = new StringReader(savess[6]))
                    {
                        sr6.Read(b, 0, 9);
                        Console.WriteLine(b);
                        var bs6 = new char[b.Length];
                        using (var srb = new StringReader(b[7].ToString()))
                        {
                            srb.Read(bs6, 0, 1);
                            // Console.WriteLine(bs6);
                            var bss = bs6.ToString();
                            if (bs6 != null)
                            {
                                var bsn = bs6.Length;
                                Debug.Assert(bs6 != null, nameof(bs6) + " != null");
                                string[] bsss = { bs6[bsn - 1].ToString() };
                            }

                            var d = new char[savess.Length];
                            string[] c = { };

                            using (var srbs = new StringReader(savess[6]))
                            {
                                srbs.Read(d, 0, 9);
                                var bar = char.GetNumericValue(d[7]);
                                var classS6 = bar;
                                wV.feetS1 = classS6;
                            }
                        }
                    }
                }

                setValues();
            }
        }
    }
}