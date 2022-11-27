using System.Diagnostics;

namespace Game
{
    public class stats
    {
        private CharCreation c = new CharCreation();
        private Program p = new Program();
        private CharPresets Ch = new CharPresets();

        public string[] atts =
        {
            "0",        // max HP                   |   * Vis atts
            "0",        // Melee damage bonus       |   |
            "0",        // Ranged damage bonus      |   V
            "0",        // Cyber damage bonus       |
            "0",        // Stamina                  |   
            "0",        // Speed                    |
            "0"         // Luck                     | -- Excluded in mult
        };

        public void loadStats()
        {
            
            switch (c.visAtt[0])
            {
                //If the class is 1
                case 1:
                    
                    break;
                
                //If the class is 2
                case 2:
                    break;
                
                //If the class is 3
                case 3:
                    break;
                
                //If the class is 4
                case 4:
                    break;
                
                //If the class is 5
                case 5:
                    break;
                
                //If the class is 6
                case 6:
                    break;
                
                //If the class is 7
                case 7:
                    break;
                
                //If the class is 8
                case 8:
                    break;
            }
        }
    }
}