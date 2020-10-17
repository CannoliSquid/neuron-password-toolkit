using System;
using System.Collections.Generic;
using System.Text;

namespace NeuronPasswordToolkit.Helpers
{
    public class StringHelper
    {
        //NumUppercase Method: Accepts a string argument and returns the number of uppercase letters it contains.
        public int NumUppercase(string str)
        {
            int Uppercase = 0;

            //Use variable as counter to count uppercase letters in the string.
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    Uppercase++;
                }
            }

            //Returns number of uppercase letters.
            return Uppercase;
        }

        //NumLowercase Method: Accepts a string argument and returns the number of lowercase letters it contains.
        public int NumLowercase(string str)
        {
            int Lowercase = 0;

            //Use variable as counter to count uppercase letters in the string.
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    Lowercase++;
                }
            }

            //Returns number of uppercase letters.
            return Lowercase;
        }

        //NumNumbers Method: Accepts a string argument and returns the number of numbers it contains.
        public int NumNumbers(string str)
        {
            int Numbers = 0;

            //Use variable as counter to count Numbers in the string.
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    Numbers++;
                }
            }

            //Returns number of Numbers.
            return Numbers;
        }

        //NumSymbols Method: Accepts a string argument and returns the number of symbols it contains.
        public int NumSymbols(string str)
        {
            int Symbols = 0;

            //Use variable as counter to count Symbols in the string.
            foreach (char ch in str)
            {
                if (char.IsSymbol(ch))
                {
                    Symbols++;
                }
            }

            //Returns number of Symbols.
            return Symbols;
        }

    }
}
