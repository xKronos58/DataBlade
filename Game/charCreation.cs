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
        private torsoAscii Torso = new torsoAscii();
        private ArmsAscii Arms = new ArmsAscii();
        
        public static string time = DateTime.Now.ToString("y.m.d.HH.mm.ss");

        private string cla;

        public byte Class;
        
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
        /// Class 3 art (6x30) [---]
        /// </summary>
        public string[] c3a =
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
        /// Class 4 art (6x30) [---]
        /// </summary>
        public string[] c4a =
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
        /// Class 5 art (6x30) [---]
        /// </summary>
        public string[] c5a =
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
        /// Class 6 art (6x30) [---]
        /// </summary>
        public string[] c6a =
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
        /// Class 7 art (6x30) [---]
        /// </summary>
        public string[] c7a =
        {
            "|===============|",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) ",
            "|     |^_^|     | Head num  : 1 / Default",
            "|     \\___/     |",
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
        /// Class 8 art (6x30) [---]
        /// </summary>
        public string[] c8a =
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
        /// Class 1 art (6x15) [Human] + Stats for cc1
        /// </summary>
        public string[] cc1a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };
        
        /// <summary>
        /// Class 2 art (6x15) [---] + Stats for cc2
        /// </summary>
        public string[] cc2a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };
        
        /// <summary>
        /// Class 3 art (6x15) [---] + Stats for cc3
        /// </summary>
        public string[] cc3a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };
        
        /// <summary>
        /// Class 4 art (6x15) [---] + Stats for cc4
        /// </summary>
        public string[] cc4a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };
        
        /// <summary>
        /// Class 5 art (6x15) [---] + Stats for cc5
        /// </summary>
        public string[] cc5a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };
        
        /// <summary>
        /// Class 6 art (6x15) [---] + Stats for cc6
        /// </summary>
        public string[] cc6a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };
        
        /// <summary>
        /// Class 7 art (6x15) [---] + Stats for cc7
        /// </summary>
        public string[] cc7a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };
        
        /// <summary>
        /// Class 8 art (6x15) [---] + Stats for cc8
        /// </summary>
        public string[] cc8a =
        {
            "|===============|                          | class att: + 10 hp",
            "|     /‾‾‾\\     | Attribute : Max hp (+ 5) | 1 = hp 5, ect",
            "|     |^_^|     | Head num  : 1 / Default  |",
            "|     \\___/     |                          |",
            "|      |  |     | Attribute : DMG (+ 10)   | 1 = dmg 10, ect",
            "|    __/  \\__   | Torso num : 1 / Default  |",
            "|   /         \\ |                          |",
            "|   | |     | | | Attribute : Luck (+ 2)   | 1 = luck 2, ect",
            "|   | |     | | | Arms num : 1 / Default   |",
            "|   VVV_____VVV |                          |",
            "|     |     |   | Attribute : speed (+ 5)  | 1 = speed 5, ect",
            "|     |  |  |   | Legs num : 1 / Default   |",
            "|     |  |  |   |                          |",
            "|     (_) (_)   | Attribute : stamina (+20)| 1 = stamina 20, ect",
            "|===============| Feet num : 1 / Default   |"
        };

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
            } if (class_ == "2 --v" || class_ == "2--v") {
                cc2();
                goto statsv;
            } if (class_ == "3 --v" || class_ == "3--v") {
                cc3();
                goto statsv;
            } if (class_ == "4 --v" || class_ == "4--v") {
                cc4();
                goto statsv;
            } if (class_ == "5 --v" || class_ == "5--v") {
                cc5();
                goto statsv;
            } if (class_ == "6 --v" || class_ == "6--v") {
                cc6();
                goto statsv;
            } if (class_ == "7 --v" || class_ == "7--v") {
                cc7();
                goto statsv;
            } if (class_ == "8 --v" || class_ == "8--v") {
                cc8();
                goto statsv;
            }
            int classi = Int32.Parse(class_);
            
            //Asks player if the class is what the want to go with
            
            Console.WriteLine("You have chosen class: " + classi + ". Is that correct? (y/n)");
            string crcCl = Console.ReadLine().ToLower();
            if (crcCl == "y") {
                goto cont;
            } else {
                goto rechoc; }
            cont: ;
            //if correct set the visAtt[Class] to the chosen class
            visAtt[0] = classi;
            
            //Catchment for incorrect numbers
            if (visAtt[0] <= 0 || visAtt[0] >= 9)
            {
                Console.WriteLine("Outside of bounds. Please input a number between 1-8");
                goto rechoc;
            }
            class1A();
            torso();
            arms();
        }

        //Note: Ascii art can be 6 lines with 1 line for user inp.
        //TODO make classes (2-8) and ascii art for all classes 
        int headnum0 = 1;
        int headnum1 = 1;
        int headnum2 = 1;
        int headnum3 = 1;
        int headnum4 = 1;
        int headnum5 = 1;
        int headnum6 = 1;
        int headnum7 = 1;
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
        
                            headnum0 = 1;
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
                            headnum0 = 2;
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
                            headnum0 = 3;
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
                            headnum0 = 4;
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
                            headnum0 = 5;
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
                            headnum0 = 6;
                            goto nxtxh;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum0++;
                            goto nxtxh;
                        case "prev":
                            Console.Clear();
                           show.PrevHead();
                        goto nxtxh;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum0;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Unexpected charecter / outside of bounds." +
                                              "\n please try agin");
                            goto nxtxh;
                    }
                    break;
                case 2:
                    foreach (string element in c2a)
                    {
                        Console.WriteLine(element);
                    }
                    
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                "or a num to skip then select to confirm)");
                    nxtxh1: ;
                    string Head1 = Console.ReadLine().ToLower();
                    switch (Head1)
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
        
                            headnum1 = 1;
                            goto nxtxh1;
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
                            headnum1 = 2;
                            goto nxtxh1;
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
                            headnum1 = 3;
                            goto nxtxh1;
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
                            headnum1 = 4;
                            goto nxtxh1;
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
                            headnum1 = 5;
                            goto nxtxh1;
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
                            headnum1 = 6;
                            goto nxtxh1;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum1++;
                            goto nxtxh1;
                        case "prev":
                            Console.Clear();
                           show.PrevHead();
                            headnum1--;
                        goto nxtxh;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum1;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Unexpected charecter / outside of bounds." +
                                              "\n please try agin");
                            goto nxtxh;
                    }       
                    break;
                case 3:
                    foreach (string element in c3a)
                    {
                        Console.WriteLine(element);
                    }
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                "or a num to skip then select to confirm)");
                    nxtxh2: ;
                    string Head2 = Console.ReadLine().ToLower();
                    switch (Head2)
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

                            headnum2 = 1;
                            goto nxtxh2;
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

                            headnum2 = 2;
                            goto nxtxh2;
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

                            headnum2 = 3;
                            goto nxtxh2;
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

                            headnum2 = 4;
                            goto nxtxh2;
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

                            headnum2 = 5;
                            goto nxtxh2;
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

                            headnum2 = 6;
                            goto nxtxh2;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum2++;
                            goto nxtxh2;
                        case "prev":
                            Console.Clear();
                            show.PrevHead();
                            headnum2--;
                            goto nxtxh2;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum2;
                            break;
                        default:
                            Console.WriteLine("Unexpected statement. Please try again...");
                            goto nxtxh2;
                        }
                    break;
                case 4:
                    foreach (string element in c4a)
                    {
                        Console.WriteLine(element);
                    }
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                "or a num to skip then select to confirm)");
                    nxtxh3: ;
                    string Head3 = Console.ReadLine().ToLower();
                    switch (Head3)
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

                            headnum3 = 1;
                            goto nxtxh3;
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

                            headnum3 = 2;
                            goto nxtxh3;
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

                            headnum3 = 3;
                            goto nxtxh3;
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

                            headnum3 = 4;
                            goto nxtxh3;
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

                            headnum3 = 5;
                            goto nxtxh3;
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

                            headnum3 = 6;
                            goto nxtxh3;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum3++;
                            goto nxtxh3;
                        case "prev":
                            Console.Clear();
                            show.PrevHead();
                            headnum3--;
                            goto nxtxh3;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum3;
                            break;
                        default:
                            Console.WriteLine("Unexpected statement. Please try again...");
                            goto nxtxh3;
                        }
                    break; 
                case 5:
                    foreach (string element in c5a)
                    {
                        Console.WriteLine(element);
                    }
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                "or a num to skip then select to confirm)");
                    nxtxh4: ;
                    string Head4 = Console.ReadLine().ToLower();
                    switch (Head4)
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

                            headnum4 = 1;
                            goto nxtxh4;
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

                            headnum4 = 2;
                            goto nxtxh4;
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

                            headnum4 = 3;
                            goto nxtxh4;
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

                            headnum4 = 4;
                            goto nxtxh4;
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

                            headnum4 = 5;
                            goto nxtxh4;
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

                            headnum4 = 6;
                            goto nxtxh4;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum4++;
                            goto nxtxh4;
                        case "prev":
                            Console.Clear();
                            show.PrevHead();
                            headnum4--;
                            goto nxtxh4;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum4;
                            break;
                        default:
                            Console.WriteLine("Unexpected statement. Please try again...");
                            goto nxtxh4;
                        }
                    break;
                case 6:
                    foreach (string element in c6a)
                    {
                        Console.WriteLine(element);
                    }
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                "or a num to skip then select to confirm)");
                    nxtxh5: ;
                    string Head5 = Console.ReadLine().ToLower();
                    switch (Head5)
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

                            headnum5 = 1;
                            goto nxtxh5;
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

                            headnum5 = 2;
                            goto nxtxh5;
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

                            headnum5 = 3;
                            goto nxtxh5;
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

                            headnum5 = 4;
                            goto nxtxh5;
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

                            headnum5 = 5;
                            goto nxtxh5;
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

                            headnum5 = 6;
                            goto nxtxh5;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum5++;
                            goto nxtxh5;
                        case "prev":
                            Console.Clear();
                            show.PrevHead();
                            headnum5--;
                            goto nxtxh5;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum5;
                            break;
                        default:
                            Console.WriteLine("Unexpected statement. Please try again...");
                            goto nxtxh5;
                        }
                    break;
                case 7: 
                    foreach (string element in c7a)
                    {
                        Console.WriteLine(element);
                    }
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                "or a num to skip then select to confirm)");
                    nxtxh6: ;
                    string Head6 = Console.ReadLine().ToLower();
                    switch (Head6)
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

                            headnum6 = 1;
                            goto nxtxh6;
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

                            headnum6 = 2;
                            goto nxtxh6;
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

                            headnum6 = 3;
                            goto nxtxh6;
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

                            headnum6 = 4;
                            goto nxtxh6;
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

                            headnum6 = 5;
                            goto nxtxh6;
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

                            headnum6 = 6;
                            goto nxtxh6;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum2++;
                            goto nxtxh6;
                        case "prev":
                            Console.Clear();
                            show.PrevHead();
                            headnum6--;
                            goto nxtxh6;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum6;
                            break;
                        default:
                            Console.WriteLine("Unexpected statement. Please try again...");
                            goto nxtxh6;
                        }
                    break;
                case 8:
                    foreach (string element in c8a)
                    {
                        Console.WriteLine(element);
                    }
                    //Choosing the head of the player
                    Console.WriteLine("Chose which head you want. (type next for the next head "+
                                      "or a num to skip then select to confirm)");
                    nxtxh7: ;
                    string Head7 = Console.ReadLine().ToLower();
                    switch (Head7)
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

                            headnum7 = 1;
                            goto nxtxh7;
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

                            headnum7 = 2;
                            goto nxtxh7;
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

                            headnum7 = 3;
                            goto nxtxh7;
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

                            headnum7 = 4;
                            goto nxtxh7;
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

                            headnum7 = 5;
                            goto nxtxh7;
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

                            headnum7 = 6;
                            goto nxtxh7;
                        case "next":
                            Console.Clear();
                            show.NextHead();
                            headnum7++;
                            goto nxtxh7;
                        case "prev":
                            Console.Clear();
                            show.PrevHead();
                            headnum7--;
                            goto nxtxh7;
                        case "select":
                            Console.Clear();
                            visAtt[1] = headnum7;
                            break;
                        default:
                            Console.WriteLine("Unexpected statement. Please try again...");
                            goto nxtxh7;
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

            Console.WriteLine("Hit \"Enter\" to go back");
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

            Console.WriteLine("Hit \"Enter\" to go back");
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

            Console.WriteLine("Hit \"Enter\" to go back");
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

            Console.WriteLine("Hit \"Enter\" to go back");
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

            Console.WriteLine("Hit \"Enter\" to go back");
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

            Console.WriteLine("Hit \"Enter\" to go back");
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

            Console.WriteLine("Hit \"Enter\" to go back");
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

            Console.WriteLine("Hit \"Enter\" to go back");
            string ccvo = Console.ReadLine();
            Console.Clear();
        }

        private int currentSpot = 1;
        private int[] heads =
        {
            0,
            0,
            0
        };
        
        /// <summary>
        /// Stores visAtt vals but changed for things like allHeads[this.ch[1]]
        /// </summary>
        private int[] CH =
        {
            0,
            0
        };
        
        
        /// <summary>
        /// Writes the custom head using some multiplication rather than a switch() w/ class and visatt
        /// </summary>
        public void writeHeads()
        {
            //Used because it is minipulated and changed from visAtt
            CH[0] = (int)this.visAtt[0];
            CH[1] = (int)this.visAtt[1];
            
            heads[0] = CH[1] * 3 - 3; //heads[0] = (CH[1] * 3 - 3) * CH[0]; what it will look like when class imp happens
            heads[1] = CH[1] * 3 - 2; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            heads[2] = CH[1] * 3 - 1; //heads[0] = (CH[1] * 3 - 3) * CH[0];

            Console.WriteLine(this.Head.allHeads[this.heads[0]]);
            Console.WriteLine(this.Head.allHeads[this.heads[1]]);
            Console.WriteLine(this.Head.allHeads[this.heads[2]]);
        }
        
        //Keeps current position of the torso
        int torsoPos = 0;
        
        /// <summary>
        /// Same as nextHead() changes between the next torso on call
        /// </summary>
        public void nextTorso()
        {
            currentSpot = torsoPos; 
            currentSpot++;
            //Stops current spot from going to 7+
            if (currentSpot == 7)
            {
                currentSpot = 0;
            }

            int[] heads =
            {
                0,
                0,
                0
            };

            int[] CH =
            {
                (int)this.visAtt[0],
                (int)this.visAtt[1]
            };
            
            heads[0] = CH[1] * 3 - 3; //heads[0] = (CH[1] * 3 - 3) * CH[0]; what it will look like when class imp happens
            heads[1] = CH[1] * 3 - 2; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            heads[2] = CH[1] * 3 - 1; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            
            switch (currentSpot)
            {
                case 1:
                    this.writeHeads();
                    foreach (string element in this.Torso.torso1a)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    this.writeHeads();
                    foreach (string element in this.Torso.torso2a)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 3:
                    this.writeHeads();
                    foreach (string element in this.Torso.torso3a)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 4:
                    this.writeHeads();
                    foreach (string element in this.Torso.torso4a)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 5:
                    this.writeHeads();
                    foreach (string element in this.Torso.torso5a)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 6:
                    this.writeHeads();
                    foreach (string element in this.Torso.torso6a)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
            }
        }

        /// <summary>
        /// Allows the player to customize the torso of thier charecter 
        /// </summary>
        public void torso()
        {
            
            // Allows the visAtt to be minipulated
            int[] CH =
            {
                (int)visAtt[0],
                (int)visAtt[1]
            };

            //Used for which headnum should be accessed in the array
            int[] heads =
            {
                0,
                0,
                0
            };
            
            //Logic for printing heads (Stored in an array) 
            // If the head selected is 4 CH[1] or the head num will be mult by 3 (Size of head
            // in array) and then 3 is subtracted for the first one and so on
            //TODO Impliment diffrend heads for diffrent class 
            heads[0] = CH[1] * 3 - 3; //heads[0] = (CH[1] * 3 - 3) * CH[0]; what it will look like when class imp happens
            heads[1] = CH[1] * 3 - 2; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            heads[2] = CH[1] * 3 - 1; //heads[0] = (CH[1] * 3 - 3) * CH[0];

            Console.WriteLine("Chose which torso you want. (type next for the next torso "+
                              "or a num to skip then select to confirm)");
            nxttc: ;
            string torso = Console.ReadLine().ToLower();
            Console.Clear();
            switch (torso)
            {
                case "1":
                    //Writes the selected head
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the selected torso (W/ default arms)
                    foreach (string element in this.Torso.torso1a)
                    {
                        Console.WriteLine(element);
                    }
                    //Writes remaining lower body
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Says the the current torso is the first one 
                    torsoPos = 1;
                    goto nxttc;
                case "2":
                    //Writes the selected head
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the selected torso (W/ default arms)
                    foreach (string element in this.Torso.torso2a)
                    {
                        Console.WriteLine(element);
                    }
                    //Writes remaining lower body
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Says the the current torso is the second one 
                    torsoPos = 2;
                    goto nxttc;
                case "3":
                    //Writes the selected head
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the selected torso (W/ default arms)
                    foreach (string element in this.Torso.torso3a)
                    {
                        Console.WriteLine(element);
                    }
                    //Writes remaining lower body
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Says the the current torso is the third one 
                    torsoPos = 3;
                    goto nxttc;
                case "4":      
                    //Writes the selected head
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the selected torso (W/ default arms)
                    foreach (string element in this.Torso.torso4a)
                    {
                        Console.WriteLine(element);
                    }
                    //Writes remaining lower body
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Says the the current torso is the fourth one 
                    torsoPos = 4;
                    goto nxttc;
                case "5":
                    //Writes the selected head
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the selected torso (W/ default arms)
                    foreach (string element in this.Torso.torso5a)
                    {
                        Console.WriteLine(element);
                    }
                    //Writes remaining lower body
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Says the the current torso is the fifth one 
                    torsoPos = 5;
                    goto nxttc;
                case "6":
                    //Writes the selected head
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the selected torso (W/ default arms)
                    foreach (string element in this.Torso.torso6a)
                    {
                        Console.WriteLine(element);
                    }
                    //Writes remaining lower body
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Says the the current torso is the sixth one 
                    torsoPos = 6;
                    goto nxttc;
                case "prev":
                    //Decrements the torso pos by 1 
                    torsoPos--;
                    goto nxttc;
                case "next":
                    nextTorso();
                    //Incriments
                    torsoPos++;
                    goto nxttc;
                case "select":
                    visAtt[2] = torsoPos;
                    break;
                default:
                    Console.WriteLine("Unexpected action, please try again");
                    goto nxttc;
            }
        }
        //Stores the current position of the arms =
        int armsPos = 1;
        
        int nexarmpos = 1;
        public void nextArm()
        {
            //Allows visAtt[] to be minipulated
            int[] CH =
            {
                (int)visAtt[0],
                (int)visAtt[1],
                (int)visAtt[2]
            };
            
            //Stores the current position of the arms =
            int armsPos = 1;
            
            //Used to store head logic
            int[] heads =
            {
                0,
                0,
                0
            };

            int[] torsos =
            {
                0,
                0,
                0,
                0,
                0
            };
            
            //Logic for printing heads (Stored in an array) 
            // If the head selected is 4 CH[1] or the head num will be mult by 3 (Size of head
            // in array) and then 3 is subtracted for the first one and so on
            heads[0] = CH[1] * 3 - 3; //heads[0] = (CH[1] * 3 - 3) * CH[0]; what it will look like when class imp happens
            heads[1] = CH[1] * 3 - 2; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            heads[2] = CH[1] * 3 - 1; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            
            //Stores which torso is selected
            torsos[0] = CH[2] * 5 - 5;
            torsos[1] = CH[2] * 5 - 4;
            torsos[2] = CH[2] * 5 - 3;
            torsos[3] = CH[2] * 5 - 2;
            torsos[4] = CH[2] * 5 - 1;

            // nexarmpos = armsPos + 1;
            nexarmpos++;
            if (nexarmpos == 7)
            {
                nexarmpos = 1;
            }
            
            switch (nexarmpos)
            {
                case 1:
                    nexarmpos = 1;
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm1h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm1h[0]);
                    Console.WriteLine(this.Arms.lArm1h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm1h[1]);
                    Console.WriteLine(this.Arms.lArm1h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm1h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    nexarmpos = 2;
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm2h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm2h[0]);
                    Console.WriteLine(this.Arms.lArm2h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm2h[1]);
                    Console.WriteLine(this.Arms.lArm2h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm2h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 3:
                    nexarmpos = 3;
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm3h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm3h[0]);
                    Console.WriteLine(this.Arms.lArm3h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm3h[1]);
                    Console.WriteLine(this.Arms.lArm3h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm3h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 4:
                    nexarmpos = 4;
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm4h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm4h[0]);
                    Console.WriteLine(this.Arms.lArm4h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm4h[1]);
                    Console.WriteLine(this.Arms.lArm4h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm4h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 5:
                    nexarmpos = 5;
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm5h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm5h[0]);
                    Console.WriteLine(this.Arms.lArm5h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm5h[1]);
                    Console.WriteLine(this.Arms.lArm5h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm5h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 6:
                    nexarmpos = 6;
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm6h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm6h[0]);
                    Console.WriteLine(this.Arms.lArm6h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm6h[1]);
                    Console.WriteLine(this.Arms.lArm6h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm6h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
            }
        }
        
        /// <summary>
        /// Allows the player to change which arms are selected
        /// </summary>
        public void arms()
        {
            
            //Allows visAtt[] to be minipulated
            int[] CH =
            {
                (int)visAtt[0],
                (int)visAtt[1],
                (int)visAtt[2]
            };

            //Used to store head logic
            int[] heads =
            {
                0,
                0,
                0
            };

            int[] torsos =
            {
                0,
                0,
                0,
                0,
                0
            };
            
            //Logic for printing heads (Stored in an array) 
            // If the head selected is 4 CH[1] or the head num will be mult by 3 (Size of head
            // in array) and then 3 is subtracted for the first one and so on
            heads[0] = CH[1] * 3 - 3; //heads[0] = (CH[1] * 3 - 3) * CH[0]; what it will look like when class imp happens
            heads[1] = CH[1] * 3 - 2; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            heads[2] = CH[1] * 3 - 1; //heads[0] = (CH[1] * 3 - 3) * CH[0];
            
            //Stores which torso is selected
            torsos[0] = CH[2] * 5 - 5;
            torsos[1] = CH[2] * 5 - 4;
            torsos[2] = CH[2] * 5 - 3;
            torsos[3] = CH[2] * 5 - 2;
            torsos[4] = CH[2] * 5 - 1;
            
            Console.WriteLine("type which num arms or \"next\" or \"prev\" " +
                              "and use \"select\" to choose");
            nxtcha: ;
            
            string armSel = Console.ReadLine().ToLower();
            Console.Clear();
            switch (armSel)
            {
                case "1":
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm1h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm1h[0]);
                    Console.WriteLine(this.Arms.lArm1h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm1h[1]);
                    Console.WriteLine(this.Arms.lArm1h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm1h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Stores position of the arm
                    armsPos = 1;
                    goto nxtcha;
                case "2":
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm2h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm2h[0]);
                    Console.WriteLine(this.Arms.lArm2h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm2h[1]);
                    Console.WriteLine(this.Arms.lArm2h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm2h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Stores position of the arm
                    armsPos = 2;
                    goto nxtcha;
                case "3":
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm3h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm3h[0]);
                    Console.WriteLine(this.Arms.lArm3h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm3h[1]);
                    Console.WriteLine(this.Arms.lArm3h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm3h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Stores position of the arm
                    armsPos = 3;
                    goto nxtcha;
                case "4":
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm4h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm4h[0]);
                    Console.WriteLine(this.Arms.lArm4h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm4h[1]);
                    Console.WriteLine(this.Arms.lArm4h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm4h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Stores position of the arm
                    armsPos = 4;
                    goto nxtcha;
                case "5":
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm5h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm5h[0]);
                    Console.WriteLine(this.Arms.lArm5h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm5h[1]);
                    Console.WriteLine(this.Arms.lArm5h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm5h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Stores position of the arm
                    armsPos = 5;
                    goto nxtcha;
                case "6":
                    //Writes the head to the console
                    Console.WriteLine(this.Head.allHeads[heads[0]]);
                    Console.WriteLine(this.Head.allHeads[heads[1]]);
                    Console.WriteLine(this.Head.allHeads[heads[2]]);
                    //Writes the torso to the console w/o arms and hands
                    Console.WriteLine(this.Torso.allTorsos[torsos[0]]);
                    Console.WriteLine(this.Torso.allTorsos[torsos[1]]);
                    Console.WriteLine(this.Arms.lArm6h[0]
                                      + this.Torso.allTorsos[torsos[2]]
                                      + this.Arms.rArm6h[0]);
                    Console.WriteLine(this.Arms.lArm6h[1]
                                      + this.Torso.allTorsos[torsos[3]]
                                      + this.Arms.rArm6h[1]);
                    Console.WriteLine(this.Arms.lArm6h[2]
                                      + this.Torso.allTorsos[torsos[4]]
                                      + this.Arms.rArm6h[2]);
                    //Writes lowerbody
                    foreach (string element in this.Torso.lowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    //Stores position of the arm
                    armsPos = 6;
                    goto nxtcha;
                case "next":
                    nextArm();
                    currentSpot++;
                    goto nxtcha;
                case "prev":
                    currentSpot -=2;
                    nextArm();
                    currentSpot--;
                    goto nxtcha;
                case "select":
                    visAtt[3] = armsPos;
                    break;
                default:
                    Console.WriteLine("Unexpected arg pelease try again");
                    goto nxtcha;
            }
        }
    }
}