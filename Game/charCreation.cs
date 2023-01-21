using System;
using System.IO;
using System.Threading;

namespace Game
{
    // ReSharper disable all InconsistentNaming
    // Lmao this shut up 53+ warnings... 
    public class CharCreation
    {
        private CustomShowFunc show = new CustomShowFunc();
        private headAscii Head = new headAscii();
        
        public static string time = DateTime.Now.ToString("y.m.d.HH.mm.ss");

        private string cla;

        public byte Class;

        public string[] Class1 /* Regular */ =
        {
            "Regular", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };

        public string[] Class2 /*  */ =
        {
            "---", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };

        public string[] Class3 /*  */ =
        {
            "---", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };

        public string[] Class4 /*  */ =
        {
            "---", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };

        public string[] Class5 /*  */ =
        {
            "---", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };

        public string[] Class6 /*  */ =
        {
            "---", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };

        public string[] Class7 /*  */ =
        {
            "---", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };

        public string[] Class8 /*  */ =
        {
            "---", // class name
            "0", // max HP
            "0", // Melee damage bonus
            "0", // Ranged damage bonus
            "0", // Cyber damage bonus
            "0", // Stamina
            "0", // Speed
            "0" // Luck
        };
        // string path = @"C:\\Users\\Finley\\Documents\\DataBladeSaves\\save_" + time + ".txt"; //For laptop

        public int clearTime = 3000;

        private readonly CharPresets CPR = new CharPresets();

        private Program p = new Program();
        public string path = @"C:\\Users\\Public\\DatabladeSaves\\save_" + time + ".txt";

        private byte randAttri;
        private readonly Random rnd = new Random();

        public double[] visAtt =
        {
            0, //head           |   0   |
            0, //torso          |   1   |
            0, //arms           |   2   |
            0, //legs           |   3   |
            0, //hands          |   4   |
            0  //shoes &! Feet  |   5   |
        };

        public void randomChar()
        {
            Class = (byte)rnd.Next(1, 8);
            visAtt[0] = rnd.Next(1, 6);
            visAtt[1] = rnd.Next(1, 6);
            visAtt[2] = rnd.Next(1, 6);
            visAtt[3] = rnd.Next(1, 6);
            visAtt[4] = rnd.Next(1, 6);
            visAtt[5] = rnd.Next(1, 6);
            switch (Class)
            {
                case 1:
                    cla = Class1[0];
                    break;
                case 2:
                    cla = Class2[0];
                    break;
                case 3:
                    cla = Class3[0];
                    break;
                case 4:
                    cla = Class4[0];
                    break;
                case 5:
                    cla = Class5[0];
                    break;
                case 6:
                    cla = Class6[0];
                    break;
                case 7:
                    cla = Class7[0];
                    break;
                case 8:
                    cla = Class8[0];
                    break;
            }

            saveRace();
        }

        private void saveRace()
        {
            if (!File.Exists(path))
                using (var sw = File.CreateText(path))
                {
                    sw.WriteLine("Class: " + Class + " (" + cla + ")");
                    Console.WriteLine("Saving: 12.5%");
                    sw.WriteLine("head : " + visAtt[0]);
                    Console.WriteLine("Saving: 25%");
                    sw.WriteLine("torso: " + visAtt[1]);
                    Console.WriteLine("Saving: 37.5%");
                    sw.WriteLine("arms : " + visAtt[2]);
                    Console.WriteLine("Saving: 50%");
                    sw.WriteLine("legs : " + visAtt[3]);
                    Console.WriteLine("Saving: 62.5");
                    sw.WriteLine("hands: " + visAtt[4]);
                    Console.WriteLine("Saving: 75%");
                    sw.WriteLine("feet : " + visAtt[5]);
                    Console.WriteLine("Saving: 87.5%");
                    sw.WriteLine("-----End Of Save--------");
                    Console.WriteLine("Saving: 99%");
                    sw.WriteLine("Save time: " + time + "       (Format: y.m.d.HH.mm.ss)");
                    Console.WriteLine("Done!");
                    Thread.Sleep(clearTime);
                    Console.Clear();
                }
        }

        public void presetChar()
        {
            Console.WriteLine("There are 8 presets listed below please type the number of the preset " +
                              "\n(If you want to query contents of the preset type num/contents e.g.\"8/contents\")");
            crctW1: ;
            Console.WriteLine("1 (Regular), 2 (---), 3 (---), 4 (---), 5 (---), 6 (---), 7 (---), 8 (---)");
            var presetNum = Console.ReadLine().ToLower();
            switch (presetNum)
            {
                case "1":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct1 = Console.ReadLine().ToLower();
                    if (crct1 == "yes" || crct1 == "1" || crct1 == "y")
                        goto crct1;
                    if (crct1 == "no" || crct1 == "2" || crct1 == "n") goto crctW1;
                    crct1: ;
                    Class = (byte)CPR.preset1[0];
                    visAtt[0] = CPR.preset1[1];
                    visAtt[0] = CPR.preset1[2];
                    visAtt[0] = CPR.preset1[3];
                    visAtt[0] = CPR.preset1[4];
                    visAtt[0] = CPR.preset1[5];
                    visAtt[0] = CPR.preset1[6];
                    saveRace();
                    break;
                case "1/contents":
                    break;
                case "2":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct2 = Console.ReadLine().ToLower();
                    if (crct2 == "yes" || crct2 == "1" || crct2 == "y")
                        goto crct2;
                    if (crct2 == "no" || crct2 == "2" || crct2 == "n") goto crctW1;
                    crct2: ;
                    Class = (byte)CPR.preset2[0];
                    visAtt[0] = CPR.preset2[1];
                    visAtt[0] = CPR.preset2[2];
                    visAtt[0] = CPR.preset2[3];
                    visAtt[0] = CPR.preset2[4];
                    visAtt[0] = CPR.preset2[5];
                    visAtt[0] = CPR.preset2[6];
                    saveRace();
                    break;
                case "2/contents":
                    break;
                case "3":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct3 = Console.ReadLine().ToLower();
                    if (crct3 == "yes" || crct3 == "1" || crct3 == "y")
                        goto crct3;
                    if (crct3 == "no" || crct3 == "2" || crct3 == "n") goto crctW1;
                    crct3: ;
                    Class = (byte)CPR.preset3[0];
                    visAtt[0] = CPR.preset3[1];
                    visAtt[0] = CPR.preset3[2];
                    visAtt[0] = CPR.preset3[3];
                    visAtt[0] = CPR.preset3[4];
                    visAtt[0] = CPR.preset3[5];
                    visAtt[0] = CPR.preset3[6];
                    saveRace();
                    break;
                case "3/contents":
                    break;
                case "4":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct4 = Console.ReadLine().ToLower();
                    if (crct4 == "yes" || crct4 == "1" || crct4 == "y")
                        goto crct4;
                    if (crct4 == "no" || crct4 == "2" || crct4 == "n") goto crctW1;
                    crct4: ;
                    Class = (byte)CPR.preset4[0];
                    visAtt[0] = CPR.preset4[1];
                    visAtt[0] = CPR.preset4[2];
                    visAtt[0] = CPR.preset4[3];
                    visAtt[0] = CPR.preset4[4];
                    visAtt[0] = CPR.preset4[5];
                    visAtt[0] = CPR.preset4[6];
                    saveRace();
                    break;
                case "4/contents":
                    break;
                case "5":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct5 = Console.ReadLine().ToLower();
                    if (crct5 == "yes" || crct5 == "1" || crct5 == "y")
                        goto crct5;
                    if (crct5 == "no" || crct5 == "2" || crct5 == "n") goto crctW1;
                    crct5: ;
                    Class = (byte)CPR.preset5[0];
                    visAtt[0] = CPR.preset5[1];
                    visAtt[0] = CPR.preset5[2];
                    visAtt[0] = CPR.preset5[3];
                    visAtt[0] = CPR.preset5[4];
                    visAtt[0] = CPR.preset5[5];
                    visAtt[0] = CPR.preset5[6];
                    saveRace();
                    break;
                case "5/contents":
                    break;
                case "6":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct6 = Console.ReadLine().ToLower();
                    if (crct6 == "yes" || crct6 == "1" || crct6 == "y")
                        goto crct6;
                    if (crct6 == "no" || crct6 == "2" || crct6 == "n") goto crctW1;
                    crct6: ;
                    Class = (byte)CPR.preset6[0];
                    visAtt[0] = CPR.preset6[1];
                    visAtt[0] = CPR.preset6[2];
                    visAtt[0] = CPR.preset6[3];
                    visAtt[0] = CPR.preset6[4];
                    visAtt[0] = CPR.preset6[5];
                    visAtt[0] = CPR.preset6[6];
                    saveRace();
                    break;
                case "6/contents":
                    break;
                case "7":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct7 = Console.ReadLine().ToLower();
                    if (crct7 == "yes" || crct7 == "1" || crct7 == "y")
                        goto crct7;
                    if (crct7 == "no" || crct7 == "2" || crct7 == "n") goto crctW1;
                    crct7: ;
                    Class = (byte)CPR.preset7[0];
                    visAtt[0] = CPR.preset7[1];
                    visAtt[0] = CPR.preset7[2];
                    visAtt[0] = CPR.preset7[3];
                    visAtt[0] = CPR.preset7[4];
                    visAtt[0] = CPR.preset7[5];
                    visAtt[0] = CPR.preset7[6];
                    saveRace();
                    break;
                case "7/contents":
                    break;
                case "8":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    var crct8 = Console.ReadLine().ToLower();
                    if (crct8 == "yes" || crct8 == "1" || crct8 == "y")
                        goto crct8;
                    if (crct8 == "no" || crct8 == "2" || crct8 == "n") goto crctW1;
                    crct8: ;
                    Class = (byte)CPR.preset8[0];
                    visAtt[0] = CPR.preset8[1];
                    visAtt[0] = CPR.preset8[2];
                    visAtt[0] = CPR.preset8[3];
                    visAtt[0] = CPR.preset8[4];
                    visAtt[0] = CPR.preset8[5];
                    visAtt[0] = CPR.preset8[6];
                    saveRace();
                    break;
                case "8/contents":
                    break;
            }
        }

        public void customChar()
        {
            Console.WriteLine("Which class do you want to be?");
            var CSTMCLASS = Console.ReadLine();
            var CSTMCLASSI = int.Parse(CSTMCLASS);
            if (CSTMCLASSI <= 9)
                Console.WriteLine("Err: 002, Unexpected symbol (Refer to _errList.json for more details)");
        }

        /// <summary>
        /// Allows the player to make a custom character
        /// </summary>
        public void customCreation()
        {
            rechoc: ;
            statsv: ;
            Console.WriteLine("Which Class do you want to use? (1-8) " +
                              "\nOr use \" --v\" at the end of the statement to see extra about the class");
            string class_ = Console.ReadLine();
            if (class_ == "1 --v" || class_ == "1--v") {
                cc1();
                goto statsv;
            } if (class_ == "1 --v" || class_ == "1--v") {
                cc2();
                goto statsv;
            } if (class_ == "1 --v" || class_ == "1--v") {
                cc3();
                goto statsv;
            } if (class_ == "1 --v" || class_ == "1--v") {
                cc4();
                goto statsv;
            } if (class_ == "1 --v" || class_ == "1--v") {
                cc5();
                goto statsv;
            } if (class_ == "1 --v" || class_ == "1--v") {
                cc6();
                goto statsv;
            } if (class_ == "1 --v" || class_ == "1--v") {
                cc7();
                goto statsv;
            } if (class_ == "1 --v" || class_ == "1--v") {
                cc8();
                goto statsv;
            } if (class_ != "1" || class_ != "2" || class_ != "3" 
                  || class_ != "4" || class_ != "5" || class_ != "6"
                  || class_ != "7" || class_ != "8")
            {
                Console.WriteLine("Outside of bounds. Please input a number between 1-8\n" +
                                  "make sure there are no letters in the statement");
            }
            int classi = Int32.Parse(class_);
            visAtt[0] = classi;
            if (visAtt[0] <= 0 || visAtt[0] >= 8)
            {
                Console.WriteLine("Outside of bounds. Please input a number between 1-8");
                goto rechoc;
            }
            class1A();
        }

        //Note: Ascii art can be 6 lines with 1 line for user inp.
        //TODO make classes (2-8) and ascii art for all classes 
        
        /// <summary>
        /// Shows the ascii art for the specific choice
        /// </summary>
        private void class1A()
        {
            switch (visAtt[0])
            {
                case 1:// If first class is selected, Goes onto the head selection
                    foreach (string element in c1a)
                    {
                        Console.WriteLine(element);
                    }

                    int headnum = 0;
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                "or a num to skip then select to confirm)");
                    nxtxh: ;
                    string Head = Console.ReadLine().ToLower();
                    switch (Head)
                    {
                        case "1":
                            Console.Clear();
                            foreach (string element in this.Head.Head1Ascii)
                            {
                                Console.WriteLine(element);                        
                            }
            
                            foreach (string element in this.Head.LowerBody)
                            {
                                Console.WriteLine(element);
                            }
        
                            headnum = 1;
                            goto nxtxh;
                        case "2":
                            Console.Clear();
                            foreach (string element in this.Head.Head2Ascii)
                            {
                                Console.WriteLine(element);                        
                            }

                            foreach (string element in this.Head.LowerBody)
                            {
                                Console.WriteLine(element);
                            }
                            goto nxtxh;
                        case "3":
                            Console.Clear();
                            foreach (string element in this.Head.Head3Ascii)
                            {
                                Console.WriteLine(element);                        
                            }
        
                            foreach (string element in this.Head.LowerBody)
                            {
                                Console.WriteLine(element);
                            }
                            goto nxtxh;
                        case "4":
                            Console.Clear();
                            foreach (string element in this.Head.Head4Ascii)
                            {
                                Console.WriteLine(element);                        
                            }

                            foreach (string element in this.Head.LowerBody)
                            {
                                Console.WriteLine(element);
                            }
                            goto nxtxh;
                        case "5":
                            Console.Clear();
                            foreach (string element in this.Head.Head5Ascii)
                            {
                                Console.WriteLine(element);                        
                            }

                            foreach (string element in this.Head.LowerBody)
                            {
                                Console.WriteLine(element);
                            }
                            goto nxtxh;
                        case "6":
                            Console.Clear();
                            foreach (string element in this.Head.Head6Ascii)
                            {
                                Console.WriteLine(element);                        
                            }

                            foreach (string element in this.Head.LowerBody)
                            {
                                Console.WriteLine(element);
                            }
                            goto nxtxh;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            goto nxtxh;
                        case "prev":
                            Console.Clear();
                           show.PrevHead();
                        goto nxtxh;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Unexpected charecter / outside of bounds." +
                                              "\n please try agin");
                            goto nxtxh;
                    }       
                    Thread.Sleep(2000);
                    break;
                case 2:
                    foreach (string element in c2a)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 3:
                    foreach (string element in c3a)
                    {
                        Console.WriteLine(element);
                    }
                    break; 
                case 4:
                    foreach (string element in c4a)
                    {
                        Console.WriteLine(element);
                    }
                    break; 
                case 5:
                    foreach (string element in c5a)
                    {
                        Console.WriteLine(element);
                    }
                    break; 
                case 6:
                    foreach (string element in c6a)
                    {
                        Console.WriteLine(element);
                    }
                    break; 
                case 7: 
                    foreach (string element in c7a)
                    {
                        Console.WriteLine(element);
                    }
                    break; 
                case 8:
                    foreach (string element in c8a)
                    {
                        Console.WriteLine(element);
                    }
                    break;
            }
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the first class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc1()
        {
            foreach (string element in cc1a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the second class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc2()
        {
            foreach (string element in cc2a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the third class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc3()
        {
            foreach (string element in cc3a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the fourth class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc4()
        {
            foreach (string element in cc4a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the fifth class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc5()
        {
            foreach (string element in cc5a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the sixth class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc6()
        {
            foreach (string element in cc6a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the seventh class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc7()
        {
            foreach (string element in cc7a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Shows an image (Ascii art) of the eighth class then the related stats
        /// [Ascii art image 6x15]
        /// </summary>
        private void cc8()
        {
            foreach (string element in cc8a)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("type anything to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }
        
        /// <summary>
        /// Class 1 art (6x30) [Human]
        /// </summary>
        public string[] c1a =
        {
            "|===============|",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) ",
            "|     |^_^|     | Head num  : 1 / Default",
            "|     \\___/     |",
            "|      |  |     | Attribute : DMG (+ 10)",
            "|    __/  \\__   | Torso num : 1 / Default",
            "|   /         \\ |",
            "|   | |     | | | Attribute : Luck (+ 2)",
            "|   | |     | | | Arms num : 1 / Default",
            "|   VVV_____VVV |",
            "|     |     |   | Attribute : speed (+ 5)",
            "|     |  |  |   | Legs num : 1 / Default",
            "|     |  |  |   |",
            "|     (_) (_)   | Attribute : stamina (+ 20)",
            "|===============| Feet num : 1 / Default"
        };
        
        /// <summary>
        /// Class 2 art (6x30) [---]
        /// </summary>
        public string[] c2a =
        {
            "This is the ascii art for cl 2",
            " :)"
        };
        
        /// <summary>
        /// Class 3 art (6x30) [---]
        /// </summary>
        public string[] c3a =
        {
            "This is the ascii art for cl 3",
            " :)"
        };
        
        /// <summary>
        /// Class 4 art (6x30) [---]
        /// </summary>
        public string[] c4a =
        {
            "This is the ascii art for cl 4",
            " :)"
        };
        
        /// <summary>
        /// Class 5 art (6x30) [---]
        /// </summary>
        public string[] c5a =
        {
            "This is the ascii art for cl 5",
            " :)"
        };
        
        /// <summary>
        /// Class 6 art (6x30) [---]
        /// </summary>
        public string[] c6a =
        {
            "This is the ascii art for cl 6",
            " :)"
        };
        
        /// <summary>
        /// Class 7 art (6x30) [---]
        /// </summary>
        public string[] c7a =
        {
            "This is the ascii art for cl 7",
            " :)"
        };
        
        /// <summary>
        /// Class 8 art (6x30) [---]
        /// </summary>
        public string[] c8a =
        {
            "This is the ascii art for cl 8",
            " :)"
        };
        
        /// <summary>
        /// Class 1 art (6x15) [Human] + Stats for cc1
        /// </summary>
        public string[] cc1a =
        {
            "1 This is the ascii art for cl 1",
            "2 :)",
            "3",
            "4",
            "5",
            "6"
        };
        
        /// <summary>
        /// Class 2 art (6x15) [---] + Stats for cc2
        /// </summary>
        public string[] cc2a =
        {
            "This is the ascii art for cl 2",
            " :)"
        };
        
        /// <summary>
        /// Class 3 art (6x15) [---] + Stats for cc3
        /// </summary>
        public string[] cc3a =
        {
            "This is the ascii art for cl 3",
            " :)"
        };
        
        /// <summary>
        /// Class 4 art (6x15) [---] + Stats for cc4
        /// </summary>
        public string[] cc4a =
        {
            "This is the ascii art for cl 4",
            " :)"
        };
        
        /// <summary>
        /// Class 5 art (6x15) [---] + Stats for cc5
        /// </summary>
        public string[] cc5a =
        {
            "This is the ascii art for cl 5",
            " :)"
        };
        
        /// <summary>
        /// Class 6 art (6x15) [---] + Stats for cc6
        /// </summary>
        public string[] cc6a =
        {
            "This is the ascii art for cl 6",
            " :)"
        };
        
        /// <summary>
        /// Class 7 art (6x15) [---] + Stats for cc7
        /// </summary>
        public string[] cc7a =
        {
            "This is the ascii art for cl 7",
            " :)"
        };
        
        /// <summary>
        /// Class 8 art (6x15) [---] + Stats for cc8
        /// </summary>
        public string[] cc8a =
        {
            "This is the ascii art for cl 8",
            " :)"
        };

    }
}