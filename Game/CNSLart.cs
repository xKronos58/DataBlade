using System;
using System.Threading;

namespace Game
{
    public class CNSLart
    {
        public string[] titleArt =
        {
            "▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄         ▓█████▄  ██▀███   ▒█████   ██▓▓█████▄ ", //0
            "▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒ ████▄       ▒██▀ ██▌▓██   ██▒▒██▒  ██▒▓██▒▒██▀ ██▌", //1
            "░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ░██   █▌▓██  ▄█ ▒▒██░  ██▒▒██▒░██   █▌", //2
            "░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░▓█▄   ▌▒██▀▀█▄  ▒██   ██░░██░░▓█▄   ▌", //3
            "░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░▒████▓ ░██▓ ▒██▒░ ████▓▒░░██░░▒████▓ ", //4
            " ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░    ▒▒▓  ▒ ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░▓   ▒▒▓  ▒ ", //5
            " ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░    ░ ▒  ▒   ░▒ ░ ▒░  ░ ▒ ▒░  ▒ ░ ░ ▒  ▒ ", //6
            " ░ ░  ░   ░   ▒    ░        ░   ▒       ░ ░  ░   ░░   ░ ░ ░ ░ ▒   ▒ ░ ░ ░  ░ ", //7
            "   ░          ░  ░              ░  ░      ░       ░         ░ ░   ░     ░    ", //8
            " ░                                      ░                             ░      " //9
        };

        public string[] cutSceneOneText =
        {
            "Dialog Line 1",
            "Dialog Line 2",
            "Dialog Line 3",
            "Dialog Line 4",
            "Dialog Line 5",
        };

        private int dialogSleepTime1 = 2000;
        public void firstCutScene()
        {
            Console.WriteLine("The game has started!");
            foreach (string item in cutSceneOneText)
            {
                Console.WriteLine(item);
                Thread.Sleep(dialogSleepTime1);
            }
        }
    }
}