using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class DieThrow
    {
        // This is the property to hold the current value of the dice
        public int FaceValue { get; private set; }

        public static int[] diceThrowValues = new int[Program.dieCount];

        // This is the random number generator for rolling the dice.
        private Random random;

        // This is the constructor.
        public DieThrow()
        {
            // This code initializes the random number generator.
            random = new Random();

        }

        // The Roll method now handles all the dice at once, assigning their values to a static array.
        public void Roll()
        {
            for (int i = 0; i < Program.dieCount; i++)
            {
                int newRandom = random.Next(1, 7);
                diceThrowValues[i] = newRandom;

                FaceValue = newRandom;

                Program.totalValue += FaceValue;
            }
        }
    }
}

