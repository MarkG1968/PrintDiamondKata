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
            if (character < 'A' || character > 'Z')
            {
                throw new ArgumentException("Must be between A and Z");
            }

            StringBuilder diamond = new StringBuilder();

            int maximumCharacterIndex = (int)character - (int)'A';

            int numberOfLines = (maximumCharacterIndex * 2) + 1;

            for (int currentLine = 0; currentLine < numberOfLines; currentLine++)
            {
                int currentCharacter = currentLine < maximumCharacterIndex ? currentLine : numberOfLines - currentLine - 1;

                diamond.Append(Spaces(maximumCharacterIndex - currentCharacter) + IndexCharacter(currentCharacter));
 
                if (currentCharacter > 0)
                {
                    diamond.Append(Spaces((currentCharacter * 2) - 1) + IndexCharacter(currentCharacter));
                }

                diamond.AppendLine(String.Empty);
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
