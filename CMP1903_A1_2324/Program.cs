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

        public static bool currentlyTestingVal = false;

        static void Main(string[] args)
        {
            currentlyTestingVal = true;

            // This code optionally creates a testing object to verify the output and operation of other classes.
            ProgramTesting testing = new ProgramTesting();

            testing.RunTests();

            ///Main program///

            Game game = new Game();

            Console.WriteLine("\nThe total of the dice roll is: " + totalValue);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    internal class ProgramTesting
    {
        // This class can be used to run tests on other classes.
        public void RunTests()
        {
            Testing testing = new Testing();

            testing.TestGame();
            testing.TestDieResult();

            Console.WriteLine("\nTests completed successfully.");

            Program.currentlyTestingVal = false;
            Program.totalValue = 0;
        }
    }
}
