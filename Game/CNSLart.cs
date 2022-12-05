using System;
using System.Threading;

namespace Game
{
    public class CNSLart
    {
        public string[] cutSceneOneText =
        {
            "*Slam* The jail door slams.",
            "[You]: What am i going to do now",
            "[???]: Hey you want to get out of this place?",
            "[Cho]: Do you want to talk to the stranger? (y/n)",
            ""
        };

        private readonly int dialogSleepTime1 = 2000;

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

        public void firstCutScene()
        {
            Console.WriteLine("The game has started!");
            Thread.Sleep(dialogSleepTime1);
            Console.Clear();
            foreach (var item in cutSceneOneText)
            {
                Console.WriteLine(item);
                Thread.Sleep(dialogSleepTime1);
            }
        }
    }
}