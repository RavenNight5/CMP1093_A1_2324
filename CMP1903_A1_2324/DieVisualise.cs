using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class DieVisualise
    {
        private string visual1 = "·\r\n";
        private string visual2 = " ·\r\n·";
        private string visual3 = "  ·\r\n ·\r\n·";
        private string visual4 = "· ·\r\n· ·";
        private string visual5 = "· ·\r\n ·\r\n· ·";
        private string visual6 = "···\r\n···";

        private string selectedVisual = "Error: dice value not valid.";

        public string ReturnDiceVisual(int dieVal)
        {
            if (dieVal.Equals(1)) selectedVisual = visual1;
            else if (dieVal.Equals(2)) selectedVisual = visual2;
            else if (dieVal.Equals(3)) selectedVisual = visual3;
            else if (dieVal.Equals(4)) selectedVisual = visual4;
            else if (dieVal.Equals(5)) selectedVisual = visual5;
            else if (dieVal.Equals(6)) selectedVisual = visual6;

            return selectedVisual;
        }
    }
}
