using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NeuronPasswordToolkit.Controllers
{
    public class CryptoController
    {
        /*
        //Controller(s)
        CheckController checkCtrlr = new CheckController();

        //Helper(s)
        UIHelper uHelper = new UIHelper();

        //Initialize RNG
        private Random rng = new Random();

        //work on encryption methods for files
        //work on other password generation methods

        //Use C# cryptorng to make a crazy password.
        public void generateRandom()
        {
            //Declare variables.
            string answer1 = uHelper.a1TB.Text;
            string answer2 = uHelper.a2TB.Text;
            string passInProgress = "";
            string generatedPass = "";

            string specChars = checkCtrlr.isDSCChecked();

            //remove spaces in answer 1
            string answer1v2 = answer1.Replace(" ", String.Empty);
            string answer2v2 = answer2.Replace(" ", String.Empty);

            //Build string
            passInProgress += answer1v2;
            passInProgress += answer2v2;
            passInProgress += specChars;

            //Call mixString
            generatedPass = genRandom(Convert.ToInt32(uHelper.lenNUD.Value), passInProgress); ;

            //Send generated password to generated password TextBox on form.
            uHelper.gptTB.Text = generatedPass;
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
        public void generateFamiliar()
        {
            //Declare variables.
            string answer1 = uHelper.a1TB.Text;
            string answer2 = uHelper.a2TB.Text;
            string spchar1 = checkCtrlr.isDSCCheckedFamiliar().Item1;
            string spchar2 = checkCtrlr.isDSCCheckedFamiliar().Item2;
            string spchar3 = checkCtrlr.isDSCCheckedFamiliar().Item3;
            string specChars = checkCtrlr.isDSCCheckedFamiliar().Item4;
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
            string pIPv2 = leetSpeakTransform(finalPassInProgress);

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

            string final = checkCtrlr.passLengthEnforce(pIPv3, specChars);

            //replace with final when  you get this function working.
            //Finally done
            uHelper.gptTB.Text = final;
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
        }*/
    }
}
