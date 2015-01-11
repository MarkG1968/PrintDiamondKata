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
            StringBuilder diamond = new StringBuilder();

            int maximumCharacterIndex = (int)character - (int)'A';

            if (maximumCharacterIndex < 0 || maximumCharacterIndex > 25)
            {
                throw new ArgumentException("Must be between A and Z");
            }

            int numberOfLines = (maximumCharacterIndex * 2) + 1;

            for (int currentLine = 0; currentLine < numberOfLines; currentLine++)
            {
                int currentCharacter = currentLine <= maximumCharacterIndex ? currentLine : numberOfLines - currentLine -1;

                if (currentCharacter == 0)
                {
                    diamond.AppendLine(Spaces(maximumCharacterIndex) + IndexCharacter(currentCharacter));
                }
                else
                {
                    diamond.AppendLine(Spaces(maximumCharacterIndex - currentCharacter) + IndexCharacter(currentCharacter) + Spaces(((currentCharacter - 1) * 2) + 1) + IndexCharacter(currentCharacter));
                }
            }

            return diamond.ToString();
        }

        String IndexCharacter(int index)
        {
            return Convert.ToChar((int)'A' + index).ToString();
        }

        String Spaces(int number)
        {
            return new String('*', number);
        }
    }
}
