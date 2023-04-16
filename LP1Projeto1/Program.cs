using System;

namespace LP1Projeto1
{
    class Program
    {
        /// <summary>
        /// main function defining the game cycle and options of choice
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Game!");

            // count variable to count number of times user clicked buttons
            int numMoves = 0;

            // variables to store the current state of the lamps
            bool lamp1 = false;
            bool lamp2 = false;
            bool lamp3 = false;

            // variables to be used to SHOW the current state of the lamps
            string lamp1Str;
            string lamp2Str;
            string lamp3Str;

            // loop until user gets to 6 clicks on buttons
            while (numMoves < 7)
            {
                /* depending on what state each lamp is, the STR variables 
                will store the suitable value between ON or OFF, to later 
                show to the user the current state of the lamp */
                lamp1Str = lamp1 ? "ON" : "OFF";
                lamp2Str = lamp2 ? "ON" : "OFF";
                lamp3Str = lamp3 ? "ON" : "OFF";

                // shows the current status of all lamps
                Console.WriteLine("Lamps Status:");
                Console.WriteLine($"Lamp 1: {lamp1Str}\n" + 
                                  $"Lamp 2: {lamp2Str}\n" +
                                  $"Lamp 3: {lamp3Str}");

                // shows clicks made
                Console.WriteLine($"Clicks on buttons: {numMoves}");

                Console.WriteLine("Which button will you press? B1, B2 or B3.");

                string chosenBut = Console.ReadLine();

                // each if for each button
                if (chosenBut.ToLower() == "b1")
                {
                    // switches the value between TRUE or FALSE
                    lamp1 = !lamp1;

                    // increment moves by 1
                    numMoves++;
                }
                else if (chosenBut.ToLower() == "b2")
                {
                    if (lamp1 != lamp2)
                    {
                        lamp1 = !lamp1;
                        lamp2 = !lamp2;

                        // increment moves by 1
                        numMoves++;
                    }
                }
                else if (chosenBut.ToLower() == "b3")
                {
                    if (lamp2 != lamp3)
                    {
                        lamp2 = !lamp2;
                        lamp3 = !lamp3;

                        // increment moves by 1
                        numMoves++;
                    }
                }
                // when the input is not what is wanted
                else
                {
                    Console.WriteLine("No valid input");
                }

                if (lamp1 && lamp2 && lamp3)
                {
                    //update lamp booleans before ending the game
                    lamp1 = true;
                    lamp2 = true;
                    lamp3 = true;

                    /* depending on what state each lamp is, the STR variables 
                    will store the suitable value between ON or OFF, to later 
                    show to the user the current state of the lamp */
                    lamp1Str = lamp1 ? "ON" : "OFF";
                    lamp2Str = lamp2 ? "ON" : "OFF";
                    lamp3Str = lamp3 ? "ON" : "OFF";

                    Console.WriteLine("Congratulations, you won the game!");
                    Console.WriteLine("Lamps Status:");
                    
                    Console.WriteLine($"Lamp 1: {lamp1Str}\n" + 
                                      $"Lamp 2: {lamp2Str}\n" +
                                      $"Lamp 3: {lamp3Str}");

                    break;
                    
                }
            }
        }
    }
}