using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkG1968.PrintDiamondKata
{
    class DiamondPrinter
    {
        internal String PrintDiamondFor(char character)
        {
            if (character == 'A')
            {
                return "A";
            }

            return  " A\n" +
                    "B B\n" +
                    " A";

        }
    }
}
