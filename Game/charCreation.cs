using System;
using System.IO;

namespace Game
{
    public class charCreation
    {
        private Random rnd = new Random();

        Program p = new Program();

        public byte Class;
        
        int[] visAtt =
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
        
        private void saveRace()
        {
            string time = DateTime.Now.ToString("h.mm.ss");
            string path = @"C:\\Users\\Finley\\Documents\\DataBladeSaves\\save_" + time + ".txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Class: " + cla + " (" + Class + ")");
                    sw.WriteLine("head : " + visAtt[0]);
                    sw.WriteLine("torso: " + visAtt[1]);
                    sw.WriteLine("arms : " + visAtt[2]);
                    sw.WriteLine("legs : " + visAtt[3]);
                    sw.WriteLine("hands: " + visAtt[4]);
                    sw.WriteLine("feet : " + visAtt[5]);
                    sw.WriteLine("-----End Of Save--------");
                    sw.WriteLine(time);
                }
            }
        }

        public void presetChar()
        {
            
        }

        public void customChar()
        {
            
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
            "---",  // class name
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
            "---",  // class name
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
            "---",  // class name
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
            "---",  // class name
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
            "---",  // class name
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
            "---",  // class name
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
            "---",  // class name
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