using Should.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using Shouldly;

namespace MarkG1968.PrintDiamondKata
{
    public class DiamondPrinterTests
    {
        private DiamondPrinter sut;

        public DiamondPrinterTests()
        {
            sut = new DiamondPrinter();
        }

        public void PrintsADiamondForA()
        {
            sut.PrintDiamondFor('A').Should().Equal("A" + Environment.NewLine);
        }
 
        public void PrintsADiamondForB()
        {
            sut.PrintDiamondFor('B').Should().Equal("*A" + Environment.NewLine + "B*B" + Environment.NewLine + "*A" + Environment.NewLine);
        }

        public void PrintsFirstLineOfDiamondForC()
        {
            var expected = "**A";

            sut.PrintDiamondFor('C').Line(1).Should().Equal(expected);
        }

        public void PrintsSecondLineOfDiamondForC()
        {
            var expected = "*B*B";

            sut.PrintDiamondFor('C').Line(2).Should().Equal(expected);
        }

        public void PrintsADiamondForC()
        {
            var expected = "**A" + Environment.NewLine +
                           "*B*B" + Environment.NewLine +
                           "C***C" + Environment.NewLine +
                           "*B*B" + Environment.NewLine +
                           "**A" + Environment.NewLine;

            sut.PrintDiamondFor('C').Should().Equal(expected);
        }

        public void PrintsADiamondForE()
        {
            var expected = "****A" + Environment.NewLine +
                           "***B*B" + Environment.NewLine +
                           "**C***C" + Environment.NewLine +
                           "*D*****D" + Environment.NewLine +
                           "E*******E" + Environment.NewLine +
                           "*D*****D" + Environment.NewLine +
                           "**C***C" + Environment.NewLine +
                           "***B*B" + Environment.NewLine +
                           "****A" + Environment.NewLine;

            sut.PrintDiamondFor('E').Should().Equal(expected);
        }

        public void ThrowsExceptionForLessThanA()
        {
            Shouldly.Should.Throw<ArgumentException>(() => { sut.PrintDiamondFor('0'); });
        }

        public void ThrowsExceptionForMoreThanZ()
        {
            Shouldly.Should.Throw<ArgumentException>(() => { sut.PrintDiamondFor('a'); });
        }
    }
}
