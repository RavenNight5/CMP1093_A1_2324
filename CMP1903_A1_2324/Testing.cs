using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // This is a method to test the Games class.
        public void TestGame()
        {
            // This code creates a new Game object.
            Game game = new Game();

            // This part of the code compares the actual output to the output that is expected.
            Debug.Assert(Program.totalValue >= 3 && Program.totalValue <= 18, "Tests resulted in an unexpected total value.");
        }

        // Method to test the Die class
        public void TestDieResult()
        {
            // Compare the values to the expected range from the Game created in the TestGame method
            for (int i = 0; i < Program.dieCount; i++)
            {
                Debug.Assert(DieThrow.diceThrowValues[i] >= 1 && DieThrow.diceThrowValues[i] <= 6, "Unexpected die face value.");
            }
        }
    }


}