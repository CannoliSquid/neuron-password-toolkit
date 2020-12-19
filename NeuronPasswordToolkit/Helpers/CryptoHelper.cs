using NeuronPasswordToolkit.Controllers;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace NeuronPasswordToolkit.Helpers
{
    public class CryptoHelper
    {
        //Controller(s)
        IOController ioCtrlr = new IOController();
        //CryptoController cryptoCtrlr = new CryptoController();
        StringHelper sh = new StringHelper();

        //class vars
        //Initialize RNG
        private Random rng = new Random();

        //Ensure that desired password length is enforced
        public SecureString passLengthEnforce(string input, string symbs, int len)
        {
            SecureString enforcedPW = new SecureString();
            string addedSymb = "";

            while (input.Length != len)
            {
                if (input.Length > len)
                {
                    //int nAgonv6 = rng.Next(1, input.Length);
                    input = input.Remove(input.Length - 1);
                }
                else if (input.Length < len)
                {
                    int nAgon5 = rng.Next(1, symbs.Length);
                    addedSymb = symbs[nAgon5].ToString();
                    input = input + addedSymb;
                }
            }

            foreach(char c in input)
            {
                enforcedPW.AppendChar(c);
            }

            return enforcedPW;
        }

        //Come up with method that replaces characters in user answers with "similar looking" characters. Some might call it 1337 speak
        public string leetSpeakTransform(string input)
        {
            //dictionary
            var ltSwap = new Dictionary<char, char>()
            {
                {'a' , '@'},
                {'A' , '4'},
                {'4' , 'A'},
                {'e' , '3'},
                {'E' , '3'},
                {'3' , 'E'},
                {'t' , '7'},
                {'T' , '7'},
                {'7' , 'T'},
                {'l' , '1'},
                {'L' , '1'},
                {'1' , 'L'},
                {'i' , '!'},
                {'I' , '!'},
                {'b' , '8'},
                {'B' , '8'},
                {'8' , 'B'},
                {'o' , '0'},
                {'O' , '0'},
                {'0' , 'O'}
            };

            //Initialize dice for RNG
            int dice = 0;

            //Output variable
            string newishPass = "";

            foreach (char c in input)
            {
                char p;

                if (ltSwap.ContainsKey(c))
                {
                    dice = rng.Next(1, 7);
                    if (dice > 3)
                    {
                        ltSwap.TryGetValue(c, out p);
                    }
                    else
                    {
                        p = c;
                    }
                }
                else
                {
                    p = c;
                }

                newishPass += p;
            }

            //Returns number of Symbols.
            return newishPass;
        }
    }
}
