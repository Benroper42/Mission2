using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DRoller
    {
        // below calls the method to simulate the dice rolls
        public int[] SimulateRolls(int nRolls)
        {
            int[] results = new int[13];

            Random random = new Random();
            // for loop to run through however many times I want to roll the die
            for (int i = 0; i < nRolls; i++)
            {
                // simulate the roll of two die
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                // increment the corresponding result array element
                results[sum]++;
            }
            return results;
        }
    }
}
