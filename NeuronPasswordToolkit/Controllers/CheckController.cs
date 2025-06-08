using NeuronPasswordToolkit.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuronPasswordToolkit.Controllers
{
    public class CheckController
    {
        //Controller(s)
        IOController ioCtrlr = new IOController();
        //CryptoController cryptoCtrlr = new CryptoController();
        StringHelper sh = new StringHelper();

        //Initialize RNG
        private Random rng = new Random();

        //Check strength w/ Entropy
        /* public void checkEntropy()
        {
            string inputPass = uHelper.ieTB.Text;
            int numUpper = sh.NumUppercase(inputPass);
            int numLower = sh.NumLowercase(inputPass);
            int numNumbers = sh.NumNumbers(inputPass);
            int numSymbols = sh.NumSymbols(inputPass);
            int bitsOfEntropy = 0;
            int oneAndHalfCounter = 0;
            int oneCounter = 0;

            for (int z = 0; z < inputPass.Length; z++)
            {
                if (z == 0)
                {
                    bitsOfEntropy += 4;
                }
                if (z > 0 && z < 7)
                {
                    bitsOfEntropy += 2;
                }
                if (z >= 7 && z < 19)
                {
                    oneAndHalfCounter += 1;
                }
                if (z >= 19)
                {
                    oneCounter += 1;
                }
            }

            int bitsOfEntropyFinal = Convert.ToInt32(bitsOfEntropy + (oneAndHalfCounter * 1.5) + (oneCounter));

            if (numSymbols >= 1 && numUpper >= 1)
            {
                bitsOfEntropyFinal += 6;
            }

            if (bitsOfEntropyFinal >= 70)
            {
                uHelper.veoTB.Text = bitsOfEntropyFinal + " bits of entropy. It is very strong.";
                uHelper.vePB.Value = 100;
            }
            else if (bitsOfEntropyFinal >= 55)
            {
                uHelper.veoTB.Text = bitsOfEntropyFinal + " bits of entropy. It is strong.";
                uHelper.vePB.Value = 75;
            }
            else if (bitsOfEntropyFinal >= 40)
            {
                uHelper.veoTB.Text = bitsOfEntropyFinal + " bits of entropy. It is fair.";
                uHelper.vePB.Value = 50;
            }
            else if (bitsOfEntropyFinal >= 30)
            {
                uHelper.veoTB.Text = bitsOfEntropyFinal + " bits of entropy. It is weak.";
                uHelper.vePB.Value = 25;
            }
            else
            {
                uHelper.veoTB.Text = bitsOfEntropyFinal + " bits of entropy. Please make it stronger.";
                uHelper.vePB.Value = 0;
            }
        }*/

        //Strength test Checks for strd and entropy 
        /*
        public void strengthTestChecks(string pass)
        {
            //Get password from textbox.
            string password = pass;
            int numUpper = sh.NumUppercase(password);
            int numLower = sh.NumLowercase(password);
            int numNumbers = sh.NumNumbers(password);
            int numSymbols = sh.NumSymbols(password);
            int bitsOfEntropy = 0;
            int oneAndHalfCounter = 0;
            int oneCounter = 0;

            //Minimum Length.
            const int min_length = 8;

            for (int z = 0; z < password.Length; z++)
            {
                if (z == 0)
                {
                    bitsOfEntropy += 4;
                }
                if (z > 0 && z < 7)
                {
                    bitsOfEntropy += 2;
                }
                if (z >= 7 && z < 19)
                {
                    oneAndHalfCounter += 1;
                }
                if (z >= 19)
                {
                    oneCounter += 1;
                }
            }

            int bitsOfEntropyFinal = Convert.ToInt32(bitsOfEntropy + (oneAndHalfCounter * 1.5) + (oneCounter));

            if (numSymbols >= 1 && numUpper >= 1)
            {
                bitsOfEntropyFinal += 6;
            }

            if (bitsOfEntropyFinal >= 70)
            {
                ioCtrlr.mosWrite(bitsOfEntropyFinal + " bits of entropy. It is very strong.");
            }
            else if (bitsOfEntropyFinal >= 55)
            {
                ioCtrlr.mosWrite(bitsOfEntropyFinal + " bits of entropy. It is strong.");
            }
            else if (bitsOfEntropyFinal >= 40)
            {
                ioCtrlr.mosWrite(bitsOfEntropyFinal + " bits of entropy. It is fair.");
            }
            else if (bitsOfEntropyFinal >= 30)
            {
                ioCtrlr.mosWrite(bitsOfEntropyFinal + " bits of entropy. It is weak.");
            }
            else
            {
                ioCtrlr.mosWrite(bitsOfEntropyFinal + " bits of entropy. Please make the password stronger.");
            }

            if (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers >= 1 && numSymbols >= 1)
            {
                ioCtrlr.mosWrite("The generated password is very strong.");
            }
            else if ((password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers >= 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers >= 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers < 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers >= 1 && numSymbols < 1))
            {
                ioCtrlr.mosWrite("The generated password is strong.");
            }
            else if ((password.Length >= min_length && numUpper < 1 && numLower < 1 && numNumbers >= 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers < 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers >= 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers < 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers >= 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers < 1 && numSymbols < 1))
            {
                ioCtrlr.mosWrite("The generated password is average.");
            }
            else if ((password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers < 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers < 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower < 1 && numNumbers >= 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower < 1 && numNumbers < 1 && numSymbols >= 1))
            {
                ioCtrlr.mosWrite("The generated password is weak.");
            }
            else
            {
                ioCtrlr.mosWrite("The generated password is invalid.");
            }
        } */

        //Check strength
        /*public void checkStrength(string pass)
        {
            //Minimum Length.
            const int min_length = 8;

            //Get password from textbox.
            string password = pass;
            int numUpper = sh.NumUppercase(password);
            int numLower = sh.NumLowercase(password);
            int numNumbers = sh.NumNumbers(password);
            int numSymbols = sh.NumSymbols(password);

            if (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers >= 1 && numSymbols >= 1)
            {
                uHelper.strilTB.Text = "very strong.";
                uHelper.strPB.Value = 100;
            }
            else if ((password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers >= 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers >= 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers < 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers >= 1 && numSymbols < 1))
            {
                uHelper.strilTB.Text = "strong.";
                uHelper.strPB.Value = 75;
            }
            else if ((password.Length >= min_length && numUpper < 1 && numLower < 1 && numNumbers >= 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers < 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers >= 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers < 1 && numSymbols >= 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers >= 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper >= 1 && numLower >= 1 && numNumbers < 1 && numSymbols < 1))
            {
                uHelper.strilTB.Text = "average.";
                uHelper.strPB.Value = 50;
            }
            else if ((password.Length >= min_length && numUpper >= 1 && numLower < 1 && numNumbers < 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower >= 1 && numNumbers < 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower < 1 && numNumbers >= 1 && numSymbols < 1) ||
            (password.Length >= min_length && numUpper < 1 && numLower < 1 && numNumbers < 1 && numSymbols >= 1))
            {
                uHelper.strilTB.Text = "weak.";
                uHelper.strPB.Value = 25;
            }
            else
            {
                uHelper.strilTB.Text = "";
                uHelper.strPB.Value = 0;
            }
        }*/
    }
}
