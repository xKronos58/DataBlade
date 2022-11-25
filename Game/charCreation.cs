using System;
using System.IO;
using System.Linq;

namespace Game
{
    public class CharCreation
    {
        private Random rnd = new Random();

        Program p = new Program();

        private CharPresets CPR = new CharPresets();

        public byte Class;
        
        public int[] visAtt =
        {
            0, //head           |   0   |
            0, //torso          |   1   |
            0, //arms           |   2   |
            0, //legs           |   3   |
            0, //hands          |   4   |
            0, //shoes &! Feet  |   5   |
        };
        
        private byte randAttri;

        private string cla;
        
        public void randomChar()
        {
            Class = (byte)rnd.Next(1,8);
            visAtt[0] = (int)rnd.Next(1, 6);
            visAtt[1] = (int)rnd.Next(1, 6);
            visAtt[2] = (int)rnd.Next(1, 6);
            visAtt[3] = (int)rnd.Next(1, 6);
            visAtt[4] = (int)rnd.Next(1, 6);
            visAtt[5] = (int)rnd.Next(1, 6);
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
        public static string time = DateTime.Now.ToString("d.HH.mm.ss");
        public string path = @"C:\\Users\\Public\\DatabladeSaves\\save_" + time + ".txt";
        // string path = @"C:\\Users\\Finley\\Documents\\DataBladeSaves\\save_" + time + ".txt"; //For laptop
        private void saveRace()
        {

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
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
                    sw.WriteLine(time);
                    Console.WriteLine("Done!");
                }
            }
        }

        public void presetChar()
        {
            Console.WriteLine("There are 8 presets listed below please type the number of the preset " +
                              "\n(If you want to query contents of the preset type num/contents e.g.\"8/contents\")");
            crctW1: ;
            Console.WriteLine("1 (Regular), 2 (---), 3 (---), 4 (---), 5 (---), 6 (---), 7 (---), 8 (---)");
            String presetNum = Console.ReadLine().ToLower();
            switch (presetNum)
            {
                case "1":
                    Console.WriteLine("You have chosen: " + presetNum + " Is that correct?");
                    String crct1 = Console.ReadLine().ToLower();
                    if (crct1 == "yes" || crct1 == "1" || crct1 == "y")
                    {
                        goto crct1;
                    } else if (crct1 == "no" || crct1 == "2" || crct1 == "n")
                    {
                        goto crctW1;
                    }
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
                    String crct2 = Console.ReadLine().ToLower();
                    if (crct2 == "yes" || crct2 == "1" || crct2 == "y")
                    {
                        goto crct2;
                    } else if (crct2 == "no" || crct2 == "2" || crct2 == "n")
                    {
                        goto crctW1;
                    }
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
                    String crct3 = Console.ReadLine().ToLower();
                    if (crct3 == "yes" || crct3 == "1" || crct3 == "y")
                    {
                        goto crct3;
                    } else if (crct3 == "no" || crct3 == "2" || crct3 == "n")
                    {
                        goto crctW1;
                    }
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
                    String crct4 = Console.ReadLine().ToLower();
                    if (crct4 == "yes" || crct4 == "1" || crct4 == "y")
                    {
                        goto crct4;
                    } else if (crct4 == "no" || crct4 == "2" || crct4 == "n")
                    {
                        goto crctW1;
                    }
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
                    String crct5 = Console.ReadLine().ToLower();
                    if (crct5 == "yes" || crct5 == "1" || crct5 == "y")
                    {
                        goto crct5;
                    } else if (crct5 == "no" || crct5 == "2" || crct5 == "n")
                    {
                        goto crctW1;
                    }
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
                    String crct6 = Console.ReadLine().ToLower();
                    if (crct6 == "yes" || crct6 == "1" || crct6 == "y")
                    {
                        goto crct6;
                    } else if (crct6 == "no" || crct6 == "2" || crct6 == "n")
                    {
                        goto crctW1;
                    }
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
                    String crct7 = Console.ReadLine().ToLower();
                    if (crct7 == "yes" || crct7 == "1" || crct7 == "y")
                    {
                        goto crct7;
                    } else if (crct7 == "no" || crct7 == "2" || crct7 == "n")
                    {
                        goto crctW1;
                    }
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
                    String crct8 = Console.ReadLine().ToLower();
                    if (crct8 == "yes" || crct8 == "1" || crct8 == "y")
                    {
                        goto crct8;
                    } else if (crct8 == "no" || crct8 == "2" || crct8 == "n")
                    {
                        goto crctW1;
                    }
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
            String CSTMCLASS = Console.ReadLine();
            int CSTMCLASSI = Int32.Parse(CSTMCLASS); 
            if (CSTMCLASSI <= 9)
            {
                Console.WriteLine("Err: 002, Unexpected symbol (Refer to _errList.json for more details)");
            }
        }

        public string[] Class1 /* Regular */ =
        {
            "Regular",  // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
        
        public string[] Class2 /*  */ =
        {
            "---",      // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
        
        public string[] Class3 /*  */ =
        {
            "---",      // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
        
        public string[] Class4 /*  */ =
        {
            "---",      // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
        
        public string[] Class5 /*  */ =
        {
            "---",      // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
        
        public string[] Class6 /*  */ =
        {
            "---",      // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
        
        public string[] Class7 /*  */ =
        {
            "---",      // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
        
        public string[] Class8 /*  */ =
        {
            "---",      // class name
            "0",        // max HP
            "0",        // Melee damage bonus
            "0",        // Ranged damage bonus
            "0",        // Cyber damage bonus
            "0",        // Stamina
            "0",        // Speed
            "0"         // Luck
        };
    }
}