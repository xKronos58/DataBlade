using System;

namespace Game
{
    // ReSharper disable all InconsistentNaming
    public class CustomShowFunc
    {
        private headAscii Head = new headAscii();

        private int currentSpot;
        
        /// <summary>
        /// Shows the next head for the custom char creation
        /// (Inc shows art)
        /// </summary>
        public void NextHead()
        {
            currentSpot++;
            if (currentSpot == 7)
            {
                currentSpot = 1;
            }
            switch (currentSpot)
            {
                case 1:
                    foreach (string element in Head.Head1Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    foreach (string element in Head.Head2Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 3:
                    foreach (string element in Head.Head3Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 4:
                    foreach (string element in Head.Head4Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 5:
                    foreach (string element in Head.Head5Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 6:
                    foreach (string element in Head.Head6Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
            }
        }

        /// <summary>
        /// Shows the previous head for the custom char creation
        /// (Inc shows art)
        /// </summary>
        public void PrevHead()
        {
            currentSpot--;
            if (currentSpot == 0)
            {
                currentSpot = 6;
            }
            switch (currentSpot)
            {
                case 1:
                    foreach (string element in Head.Head1Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    foreach (string element in Head.Head2Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 3:
                    foreach (string element in Head.Head3Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 4:
                    foreach (string element in Head.Head4Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 5:
                    foreach (string element in Head.Head5Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 6:
                    foreach (string element in Head.Head6Ascii)
                    {
                        Console.WriteLine(element);
                    }

                    foreach (string element in Head.LowerBody)
                    {
                        Console.WriteLine(element);
                    }
                    break;
            }
        }
    }
}