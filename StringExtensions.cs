using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkG1968.PrintDiamondKata
{
    public static class StringExtensions
    {
        public static String Line(this String source, int lineNumber)
        {
            return source.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Skip(lineNumber - 1).First();
        }
    }
}
