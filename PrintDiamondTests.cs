using Should.Fluent;
using System;
using System.Linq;
using Shouldly;

namespace MarkG1968.PrintDiamondKata
{
    public class PrintDiamondTests
    {
        private DiamondPrinter sut;

        public PrintDiamondTests()
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

            var result = sut.PrintDiamondFor('C');

            var firstLine = result.Split(new [] {Environment.NewLine}, StringSplitOptions.None).First();

            firstLine.Should().Equal(expected);
        }

        public void PrintsSecondLineOfDiamondForC()
        {
            var expected = "*B*B";

            var result = sut.PrintDiamondFor('C');

            var secondLine = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Skip(1).First();

            secondLine.Should().Equal(expected);
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
