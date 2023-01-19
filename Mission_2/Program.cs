using System;

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
            int diceRolls = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int[] rollResults = new int[11];

            // simulate the roll of two dice for the DiceRolls input
            for (int i = 0; i < diceRolls; i++)
            {
                rollResults[r.Next(6) + r.Next(6)]++;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls");
            Console.WriteLine("Total number of rolls = " + diceRolls +"\n");

            // determine and print out asterisks according to percentages (numbers are rounded down)
            for (int i = 0; i < 11; i++)
            {
                int percent = (rollResults[i] * 100) / diceRolls;

                string asterisks = "\t";
                for (int j = 0; j < percent; j++)
                {
                    asterisks += "*";
                }
                Console.WriteLine((i + 2) + ": " + asterisks);
            }
        }
    }
}