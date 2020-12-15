using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using NeuronPasswordToolkit.Helpers;

namespace NeuronPasswordToolkit.Controllers
{
    public class CryptoController
    {
        //Controller(s)
        //CheckController checkCtrlr = new CheckController();
        CryptoHelper crypto = new CryptoHelper();

        //Initialize RNG
        private Random rng = new Random();

        //work on encryption methods for files
        //work on other password generation methods

        //Use C# cryptorng to make a crazy password.
        public string generateRandom(string a1, string a2, string sChars, int len)
        {
            //Declare variables.
            string answer1 = a1;
            string answer2 = a2;
            string passInProgress = "";
            string generatedPass = "";

            string specChars = sChars;

            //remove spaces in answer 1
            string answer1v2 = answer1.Replace(" ", String.Empty);
            string answer2v2 = answer2.Replace(" ", String.Empty);

            //Build string
            passInProgress += answer1v2;
            passInProgress += answer2v2;
            passInProgress += specChars;

            //Call mixString
            generatedPass = genRandom(len, passInProgress);

            //Send generated password to generated password TextBox on form.
            return generatedPass;
        }

        //generate random using crng
        static string genRandom(int length, string input)
        {
            string randString = "";
            using (RNGCryptoServiceProvider crng = new RNGCryptoServiceProvider())
            {
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
                        randString += c;
                    }
                }
                //Dispose of crng
                crng.Dispose();

                //return string
                return randString;
            }
        }

        //Generate familiar
        private string generateFamiliar(string a1, string a2, string spc1, string spc2, string spc3, string spcs, int len)
        {
            //Declare variables.
            string answer1 = a1;
            string answer2 = a2;
            string spchar1 = spc1;
            string spchar2 = spc2;
            string spchar3 = spc3;
            string specChars = spcs;
            string passInProgress = "";
            int strangecoin = 0;
            int dice = 0;
            int dice2 = 0;

            //Start building string
            passInProgress = answer1.Replace(" ", String.Empty);

            //Random Generation
            int nAgonv3 = rng.Next(1, passInProgress.Length);
            int nAgonv3p2 = rng.Next(1, passInProgress.Length);
            int nAgonv3p3 = rng.Next(1, passInProgress.Length);

            //Use random numbers to insert special characters into the password as it is being build
            string passInProgress1 = passInProgress.Insert(nAgonv3, spchar1);
            string passInProgress2 = passInProgress.Insert(nAgonv3p2, spchar2);
            string finalPassInProgress = passInProgress2.Insert(nAgonv3p3, spchar3);

            //Attempt to replace familiar characters -- currently broken --
            string pIPv2 = crypto.leetSpeakTransform(finalPassInProgress);

            //3 sided coin. More random generation
            strangecoin = rng.Next(2, 4);

            //Take x% of the first answer, rounded up.
            int splitpassnum = (pIPv2.Length / strangecoin);

            //Use splitpassnum to make substrings of the string pIPv2
            string halfpass1 = pIPv2.Substring(0, splitpassnum);
            string halfpass2 = pIPv2.Substring(splitpassnum);

            //More RNG LMAO
            dice = rng.Next(0, 4);
            dice2 = rng.Next(1, answer2.Length);

            //Get Chunks
            string a2chunk1 = answer2.Substring(0, (answer2.Length / 2));
            string a2chunk2 = answer2.Substring((answer2.Length / 2));

            //Together
            string pIPv3p1 = halfpass1.Insert(dice, a2chunk1);
            string pIPv3p2 = halfpass2.Insert(dice2, a2chunk2);
            string pIPv3 = pIPv3p1 + pIPv3p2;

            string final = crypto.passLengthEnforce(pIPv3, specChars, len);

            //replace with final when  you get this function working.
            //Finally done
            return final;
        }

        public string isDSCChecked(string selection, string charPool)
        {
            string specChars = "";
            string defspecialChars = "!@#$%^&*()_+-=,./";
            string specspecialChars = charPool;

            //Check for which special character set to use.
            //If specific special characters, make sure to remove white space.
            if (selection == "default")
            {
                specChars = defspecialChars;
            }
            else if (selection == "special")
            {
                specChars = specspecialChars;
                specChars = specChars.Replace(" ", String.Empty);
            }

            return specChars;
        }

        public (string, string, string, string) isSCCheckedFamiliar(string selection, string charPool)
        {
            string specChars = "";
            string spchar1 = "";
            string spchar2 = "";
            string spchar3 = "";
            string defspecialChars = "!@#$%^&*()_+-=,./";
            string specspecialChars = charPool;

            //Check for which special character set to use.
            //If specific special characters, make sure to remove white space.
            //Pick 2 special characters out at random
            if (selection == "default")
            {
                specChars = defspecialChars;
                int nAgon = rng.Next(1, defspecialChars.Length);
                int nAgon2 = rng.Next(1, defspecialChars.Length);
                int nAgon3 = rng.Next(1, defspecialChars.Length);
                spchar1 = defspecialChars[nAgon].ToString();
                spchar2 = defspecialChars[nAgon2].ToString();
                spchar3 = defspecialChars[nAgon3].ToString();
            }
            else if (selection == "special")
            {
                specChars = specspecialChars;
                string specCharsFinal = specChars.Replace(" ", String.Empty);
                int nAgonv2 = rng.Next(1, specCharsFinal.Length);
                int nAgonv2p2 = rng.Next(1, specCharsFinal.Length);
                int nAgonv2p3 = rng.Next(1, specCharsFinal.Length);
                spchar1 = specCharsFinal[nAgonv2].ToString();
                spchar2 = specCharsFinal[nAgonv2p2].ToString();
                spchar3 = specCharsFinal[nAgonv2p3].ToString();
            }

            return (spchar1, spchar2, spchar3, specChars);
        }
    }
}
