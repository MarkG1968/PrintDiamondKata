using Should.Fluent;

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
            sut.PrintDiamondFor('A').Should().Equal("A");
        }
 
        public void PrintsADiamondForB()
        {
            sut.PrintDiamondFor('B').Should().Equal(" A\nB B\n A");
        }

        public void PrintsADiamondForC()
        {
            var expected = "  A\n" +
                           " B B\n" +
                           "C   C\n" +
                           " B B\n" +
                           "  A";

            sut.PrintDiamondFor('C').Should().Equal(expected);
        }
    }
}
