using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using NeuronPasswordToolkit.Helpers;

namespace NeuronPasswordToolkit.Controllers
{
    public class CryptoController
    {
        //Controller(s)
        //CheckController checkCtrlr = new CheckController();
        CryptoHelper cryptoH = new CryptoHelper();

        //Initialize RNG
        private Random rng = new Random();

        //work on encryption methods for files
        //work on other password generation methods

        //Use C# cryptorng to make a crazy password.
        public SecureString generateRandom(string a1, string a2, string sChars, int len)
        {
            //Declare variables.
            //remove spaces in answer 1
            string answer1v2 = a1.Replace(" ", String.Empty);
            string answer2v2 = a2.Replace(" ", String.Empty);
            string passInProgress = "";
            SecureString generatedPass = new SecureString();

            string[] components = new string[] { answer1v2, answer2v2, sChars };

            //Build string
            foreach(string s in components)
            {
                passInProgress += s;
            }

            //Call mixString
            generatedPass = genRandom(len, passInProgress);

            //Send generated password to generated password TextBox on form.
            return generatedPass;
        }

        //generate random using crng
        static SecureString genRandom(int length, string input)
        {
            SecureString randString = new SecureString();
            using (RNGCryptoServiceProvider crng = new RNGCryptoServiceProvider())
            {
                //potential pitfall here if not enough chars in passinprogress -- fix in later iteration by looping over again
                while (randString.Length != length)
                {
                    // Create a byte array to hold the random value.
                    byte[] randByte = new byte[1];

                    // Fill the array with a random value.
                    crng.GetBytes(randByte);

                    //Get character
                    char c = (char)randByte[0];

                    //If the byte -> character is in the input pool, add to randString
                    if (input.Contains(c))
                    {
                        randString.AppendChar(c);
                    }
                }
                //Dispose of crng
                crng.Dispose();

                //return string
                return randString;
            }
        }

        //Generate familiar
        public SecureString generateFamiliar(string a1, string a2, string spcs, int len)
        {
            //Declare variables.
            string answer1 = a1;
            string answer2 = a2;
            char[] spchar = spcs.ToCharArray();

            //Start building string
            string passInProgress = answer1.Replace(" ", String.Empty);

            //Random Generation
            int nAgonv3 = rng.Next(1, passInProgress.Length);
            int nAgonv3p2 = rng.Next(1, passInProgress.Length);
            int nAgonv3p3 = rng.Next(1, passInProgress.Length);

            //Use random numbers to insert special characters into the password as it is being build
            //look into changing into securestring
            string passInProgress1 = passInProgress.Insert(nAgonv3, spchar[0].ToString());
            string passInProgress2 = passInProgress1.Insert(nAgonv3p2, spchar[1].ToString());
            string finalPassInProgress = passInProgress2.Insert(nAgonv3p3, spchar[2].ToString());

            //Attempt to replace familiar characters -- currently broken --
            string pIPv2 = cryptoH.leetSpeakTransform(finalPassInProgress);

            //3 sided coin. More random generation
            int strangecoin = rng.Next(2, 4);

            //Take x% of the first answer, rounded up.
            int splitpassnum = (pIPv2.Length / strangecoin);

            //Use splitpassnum to make substrings of the string pIPv2
            string halfpass1 = pIPv2.Substring(0, splitpassnum);
            string halfpass2 = pIPv2.Substring(splitpassnum);

            //More RNG LMAO
            int dice = rng.Next(0, 4);
            int dice2 = rng.Next(1, answer2.Length);

            //Get Chunks
            string a2chunk1 = answer2.Substring(0, (answer2.Length / 2));
            string a2chunk2 = answer2.Substring((answer2.Length / 2));

            //Together
            string pIPv3p1 = halfpass1.Insert(dice, a2chunk1);
            string pIPv3p2 = halfpass2.Insert(dice2, a2chunk2);
            string pIPv3 = pIPv3p1 + pIPv3p2;

            SecureString final = cryptoH.passLengthEnforce(pIPv3, spcs, len);

            //replace with final when  you get this function working.
            //Finally done
            return final;
        }

        public string familiarCharMix(string selection, string charPool = "")
        {
            string finalCharPool = "";
            string defspecialChars = "!@#$%^&*()_+-=,./";
            string specspecialChars = charPool;

            //Check for which special character set to use.
            //If specific special characters, make sure to remove white space.
            //Pick 2 special characters out at random
            if (selection == "default")
            {
                int nAgon = rng.Next(1, defspecialChars.Length);
                int nAgon2 = rng.Next(1, defspecialChars.Length);
                int nAgon3 = rng.Next(1, defspecialChars.Length);
                finalCharPool += defspecialChars[nAgon].ToString();
                finalCharPool += defspecialChars[nAgon2].ToString();
                finalCharPool += defspecialChars[nAgon3].ToString();
            }
            else if (selection == "special")
            {
                int nAgonv2 = rng.Next(1, specspecialChars.Length);
                int nAgonv2p2 = rng.Next(1, specspecialChars.Length);
                int nAgonv2p3 = rng.Next(1, specspecialChars.Length);
                finalCharPool += specspecialChars[nAgonv2].ToString();
                finalCharPool += specspecialChars[nAgonv2p2].ToString();
                finalCharPool += specspecialChars[nAgonv2p3].ToString();
            }

            return finalCharPool;
        }
    }
}
