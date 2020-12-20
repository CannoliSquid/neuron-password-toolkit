using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using NeuronPasswordToolkit.Controllers;
using System.Text;
using NeuronPasswordToolkit.Interfaces;
using System.Security;
using System.Windows;
using System.Windows.Input;
using NeuronPasswordToolkit.Helpers;

namespace NeuronPasswordToolkit.ViewModels
{
    public class GeneratorViewModel : ViewModelBase
    {
        #region Variables
        IOController io = new IOController();

        #region Model Elements
        public List<string> StringQuestion
        {
            get
            {
                return new List<string>
                {
                    "What was the color of the walls in your room when you were a child?",
                    "Who is your favorite band/artist?",
                    "What was the name of the road you lived on as a child?",
                    "Where did you go for your first vacation?",
                    "What is/was your nickname?",
                    "What is the name of your favorite store?",
                    "Who is your favorite superhero?",
                    "What is your first sibling's middle name?",
                    "In what town was your High School located?",
                    "What was your favorite teacher's last name?",
                    "Who is your role model?",
                    "What was your childhood best friend's last name?",
                    "What is your favorite drink/food?"
                };
            }
        }

        private string _selectedStringQuestion { get; set; }

        public string SelectedStringQuestion
        {
            get { return _selectedStringQuestion; }
            set { _selectedStringQuestion = value; OnPropertyChanged(); }
        }

        public List<string> NumberQuestion
        {
            get
            {
                return new List<string>
                {
                    "What were the first 5 digits of your first telephone number (either cellular or home)?",
                    "What year was your favorite album released?",
                    "What is your shoe size and lucky number? (Enter as one number)",
                    "What year did you graduate from high school?",
                    "What was the most expensive thing you remember purchasing? (Round to the nearest dollar)",
                    "What was the model year of your first car?",
                    "When do you usually eat your first meal? (Enter the time as one number without formatting)",
                    "What age did you start dating? What age are you now? (Enter as one number)",
                    "What date is significant to you? (Enter as one number without formatting)"
                };
            }
        }
        private string _selectedNumberQuestion { get; set; }

        public string SelectedNumberQuestion
        {
            get { return _selectedNumberQuestion; }
            set { _selectedNumberQuestion = value; OnPropertyChanged(); }
        }

        public List<int> LengthSelector
        {
            get
            {
                return new List<int>
                {
                    8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                    31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48
                };
            }
        }
        private int _selectedLength { get; set; }

        public int SelectedLength
        {
            get { return _selectedLength; }
            set { _selectedLength = value; OnPropertyChanged(); }
        }
        #endregion

        #region Binding Variables
        private string _answeredQuestion1;
        public string AnsweredQuestion1
        {
            get { return _answeredQuestion1; }
            set { _answeredQuestion1 = value; OnPropertyChanged(); }
        }

        private string _answeredQuestion2;
        public string AnsweredQuestion2
        {
            get { return _answeredQuestion2; }
            set { _answeredQuestion2 = value; OnPropertyChanged(); }
        }

        private string _specialCharacterSet;
        public string SpecialCharacterSet
        {
            get { return _specialCharacterSet; }
            set { _specialCharacterSet = value; OnPropertyChanged(); }
        }

        private string _specialCharacters;
        public string SpecialCharacters
        {
            get { return _specialCharacters; }
            set { _specialCharacters = value; OnPropertyChanged(); }
        }

        private string _generationType;
        public string GenerationType
        {
            get { return _generationType; }
            set { _generationType = value; OnPropertyChanged(); }
        }

        private SecureString _finalProduct;
        public SecureString FinalProduct
        {
            get { return _finalProduct; }
            set { _finalProduct = value; OnPropertyChanged(); }
        }
        #endregion

        #region Commands
        public ICommand FormSpecCharsSpecificChecked { get; set; }
        public ICommand FormSpecCharsDefaultChecked { get; set; }
        public ICommand FormGenerateRandomButtonClick { get; set; }
        public ICommand FormGenerateFamiliarButtonClick { get; set; }
        public ICommand FormOutputSaveButtonClick { get; set; }
        #endregion

        /* old attempts
        private string _answeredQuestion1;
        public string AnsweredQuestion1
        {
            get => _answeredQuestion1;
            set => _answeredQuestion1 = value;
        }

        private string _answeredQuestion2;
        public string AnsweredQuestion2
        {
            get => _answeredQuestion2;
            set => _answeredQuestion2 = value;
        }

        private string _specialCharacterSet;
        public string SpecialCharacterSet
        {
            get => _specialCharacterSet;
            set => _specialCharacterSet = value;
        }

        private string _specialCharacters;
        public string SpecialCharacters
        {
            get => _specialCharacters;
            set => _specialCharacters = value;
        }

        private string _generationType;
        public string GenerationType
        {
            get => _generationType;
            set => _generationType = value;
        }

        private int _selectedLength;
        public int SelectedLength
        {
            get => _selectedLength;
            set => _selectedLength = value;
        }

        private SecureString _finalProduct;
        public SecureString FinalProduct
        {
            get => _finalProduct;
            set => _finalProduct = value;
        }*/
        #endregion

        public GeneratorViewModel()
        {
            //FormSpecCharsSpecificChecked = new RelayCommand(FormSpecCharsSpecific_Checked);
            FormSpecCharsSpecificChecked = new RelayCommand(o => FormSpecCharsSpecific_Checked());
            FormSpecCharsDefaultChecked = new RelayCommand(o => FormSpecCharsDefault_Checked());
            FormGenerateRandomButtonClick = new RelayCommand(o => FormGenerateRandomButton_Click());
            FormGenerateFamiliarButtonClick = new RelayCommand(o => FormGenerateFamiliarButton_Click());
            FormOutputSaveButtonClick = new RelayCommand(o => FormOutputSaveButton_Click());
        }

        private void FormSpecCharsSpecific_Checked()
        {
            SpecialCharacterSet = "specific";
        }

        private void FormSpecCharsDefault_Checked()
        {
            SpecialCharacterSet = "default";
        }

        private void FormGenerateRandomButton_Click()
        {
            try
            {
                GenerationType = "random";
                CreateFinalProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred", ex.ToString());
            }
        }

        private void FormGenerateFamiliarButton_Click()
        {
            try
            {
                GenerationType = "familiar";
                CreateFinalProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred", ex.ToString());
            }
        }

        private void FormOutputSaveButton_Click()
        {
            FinalProduct.MakeReadOnly();
            io.save(FinalProduct);
            FinalProduct.Dispose();
        }

        public void CreateFinalProduct()
        {
            CryptoController crypto = new CryptoController();

            try
            {
                if (SpecialCharacterSet == "specific")
                {
                    string sCharPool = SpecialCharacters.Replace(" ", String.Empty);

                    if(GenerationType == "random")
                    {
                        FinalProduct = crypto.generateRandom(AnsweredQuestion1, AnsweredQuestion2, sCharPool, SelectedLength);
                    }
                    else if(GenerationType == "familiar")
                    {
                        string mixedBag = crypto.familiarCharMix(SpecialCharacterSet, sCharPool);

                        FinalProduct = crypto.generateFamiliar(AnsweredQuestion1, AnsweredQuestion2, mixedBag, SelectedLength);
                    }
                }
                else if (SpecialCharacterSet == "default")
                {
                    string answer1 = AnsweredQuestion1;
                    string answer2 = AnsweredQuestion2;
                    string sCharPool = "!@#$%^&*()_+-=,./";
                    int length = SelectedLength;

                    if (GenerationType == "random")
                    {
                        FinalProduct = crypto.generateRandom(AnsweredQuestion1, AnsweredQuestion2, sCharPool, SelectedLength);
                    }
                    else if (GenerationType == "familiar")
                    {
                        string mixedBag = crypto.familiarCharMix(SpecialCharacterSet, sCharPool);

                        FinalProduct = crypto.generateFamiliar(AnsweredQuestion1, AnsweredQuestion2, mixedBag, SelectedLength);
                    }
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}

