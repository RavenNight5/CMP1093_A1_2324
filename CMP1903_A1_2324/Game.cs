using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private DieThrow dice;
        private DieVisualise dieVis;

        private string DieVisual = "";

        // This is the constructor.
        public Game()
        {
            dice = new DieThrow();
            dieVis = new DieVisualise();

            dice.Roll();

            for (int i = 0; i < Program.dieCount; i++)
            {
                if (Program.currentlyTestingVal.Equals(false))
                {
                    Console.WriteLine("\nThrew a " + DieThrow.diceThrowValues[i]);

                    DieVisual = dieVis.ReturnDiceVisual(DieThrow.diceThrowValues[i]);

                    Console.WriteLine(DieVisual);
                }
            }

        }

    }
}
