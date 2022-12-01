using System;

namespace Game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CNSLart art = new CNSLart();
            CharCreation cha = new CharCreation();
            LoadFunc lf = new LoadFunc();
            stats ls = new stats();


            //Player stats

            double hp;
            long chips;

            Random rnd = new Random();

            //Title screen

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n" + art.titleArt[0] + "\n" + art.titleArt[1]
                + "\n" + art.titleArt[2] + "\n" + art.titleArt[3]
                + "\n" + art.titleArt[4] + "\n" + art.titleArt[5]
                + "\n" + art.titleArt[6] + "\n" + art.titleArt[7]
                + "\n" + art.titleArt[8] + "\n" + art.titleArt[9]);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nWelcome to GAME NAME");
            Console.ResetColor();

            //Character creation

            Console.WriteLine("\n\n\nDo you wish to create your own character or have a randomised one?" +
                              "\n(Type \"rand\", \"prsts\" for a list of presets or \"cstm\" for a custom one)" +
                              "\nTo load a save type \"load\" or \"load -recent\" for the most recent save");
            inchrC: ;
            String chrC = Console.ReadLine().ToLower();
            switch (chrC)
            {
                case "rand":
                    cha.randomChar();
                    break;
                case "prsts":
                    cha.presetChar();
                    break;
                case "cstm":
                    cha.customChar();
                    break;
                case "load":
                    lf.loadSave();
                    break;
                case "load -recent":
                case "load-recent":
                    lf.recentSave();
                    break;
                default:
                    Console.WriteLine(
                        "There was a null or incorrect value\nPlease try again\nErr: 002, Unexpected symbol (check _errList.json for details)");
                    goto inchrC;
            }
            
            // ls.loadStats();
            
            //Game Loop

            art.firstCutScene();
        }
    }
}