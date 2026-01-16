using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    internal class DiceRoller
    {
        public static int[] DiceRolled { get; private set; } = null!;
        public static void Roll(int numRolls)
        { 
            DiceRolled = new int[13];
            Random rand = new Random();
            int die1 = 0;
            int die2 = 0;

            for (int i=0; i<numRolls; i++)
            {
                die1 = rand.Next(1, 7);
                die2 = rand.Next(1, 7);
                int sum = die1 + die2;
                DiceRolled[sum]++;
            }
        }

    }
}
