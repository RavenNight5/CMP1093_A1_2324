using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        public static int dieCount = 3;
        public static int totalValue = 0;

        static void Main(string[] args)
        {
            // This code creates the game object and calls its methods.
            Game game = new Game();
            
            //int total = game.RollAndReportTotal();

            //Console.WriteLine("The total of the three dice rolls is: " + total);
            Console.Write("");

            // This code optionally creates a testing object to verify the output and operation of other classes.
            ProgramTesting testing = new ProgramTesting();

            testing.RunTests();
        }
    }

    internal class ProgramTesting
    {
        // This class can be used to run tests on other classes.
        public void RunTests()
        {
            Testing testing = new Testing();

            testing.TestGame();
            testing.TestDie();

            Console.WriteLine("Tests completed successfully.");
            // As an option, you can add tests here to verify the output and operation of other classes.
            //Die die = new Die();
            //die.Roll();
            //Console.WriteLine("The face value of the die is: " + die.FaceValue);
        }
    }
}
