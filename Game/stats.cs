using System;
using System.Diagnostics;
using System.Linq;

namespace Game
{
    public class stats
    {
        private CharCreation c = new CharCreation();
        private Program p = new Program();
        private CharPresets Ch = new CharPresets();
        private statsMultiplier sm = new statsMultiplier();

        public int[] atts =
        {
            0,        // 0    max HP                   |   * Vis atts
            0,        // 1    Melee damage bonus       |   |
            0,        // 2    Ranged damage bonus      |   V
            0,        // 3    Cyber damage bonus       |
            0,        // 4    Stamina                  |   
            0,        // 5    Speed                    |
            0         // 6    Luck                     | -- Excluded in mult
        };

        public void loadStats()
        {
            
            switch (c.visAtt[0])
            {
                //If the class is 1
                case 1:
                    if (c.visAtt[1] == 1)
                    {
                        string[] head1Mi = sm.head1M.Take(3).ToArray();
                        
                        double vis1cl1at = Convert.ToDouble(head1Mi[1]);
                        
                        Console.WriteLine(vis1cl1at + "This should be sm.head1M (The first digit)");
                        
                        atts[3] = 1;
                    }
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