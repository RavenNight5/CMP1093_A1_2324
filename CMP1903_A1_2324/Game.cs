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


            //Console.WriteLine("The face value of the die just rolled is: " + FaceValue + " " + DieVisual);

        }

        // This part of the code rolls the dice and then calculates the sum, reporting the total.
        //public int RollAndReportTotal()
        //{
        //    int total = 0;

        //    foreach (Die die in dice)
        //    {
        //        die.Roll(); // This rolls each of the die.

        //        total += die.FaceValue; // This adds the current face value of the die to the total.
        //    }
        //    return total;
        //}
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // This creates a new instance of the Game itself.
    //        Game game = new Game();

    //        // This rolls the dice and reports the total value.
    //        int total = game.RollAndReportTotal();

    //        // Displays the total value.
    //        Console.WriteLine("The total of the three dice rolls is: " + total);
    //    }
    //}
}
