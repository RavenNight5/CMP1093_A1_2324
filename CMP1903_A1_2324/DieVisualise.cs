using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class DieVisualise
    {
        private string visual1 = "--1--";
        private string visual2 = "--2--";
        private string visual3 = "--3--";
        private string visual4 = "--4--";
        private string visual5 = "\n┌─────┐\r\n│o   o│\r\n│  o  │\r\n│o   o│\r\n└─────┘\n";

        private string selectedVisual = "Error: dice value not valid.";

        public string ReturnDiceVisual(int dieVal)
        {
            if (dieVal.Equals(1)) selectedVisual = visual1;
            else if (dieVal.Equals(2)) selectedVisual = visual2;
            else if (dieVal.Equals(3)) selectedVisual = visual3;
            else if (dieVal.Equals(4)) selectedVisual = visual4;
            else if (dieVal.Equals(5)) selectedVisual = visual5;

            return selectedVisual;
        }
    }
}
