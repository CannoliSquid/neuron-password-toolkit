using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using NeuronPasswordToolkit.Controllers;
using System.Text;

namespace NeuronPasswordToolkit.ViewModels
{
    public class GeneratorViewModel
    {
        

        public GeneratorViewModel()
        {
        }

        

        public void CreateFinalProduct()
        {
            CryptoController crypto = new CryptoController();

            /*try
            {
                if (SpecialCharacterSet == "specific")
                {
                    answer1 = FormMainInputA1TB.Text;
                    answer2 = FormMainInputA2TB.Text;
                    sCharPool = FormSpecCharsTB.Text;
                    sChars = sCharPool.Replace(" ", String.Empty);
                    length = (int)FormLengthInputLengthSelect.SelectedItem;

                    //return (answer1, answer2, sCharPool, length);
                }
                else if (SpecialCharacterSet == "default")
                {
                    answer1 = FormMainInputA1TB.Text;
                    answer2 = FormMainInputA2TB.Text;
                    sCharPool = "!@#$%^&*()_+-=,./";
                    length = (int)FormLengthInputLengthSelect.SelectedItem;

                    //return (answer1, answer2, sCharPool, length);
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            
            FinalProduct = crypto.generateRandom(AnsweredQuestion1, AnsweredQuestion2, , SelectedLength);*/
        }
    }
}
