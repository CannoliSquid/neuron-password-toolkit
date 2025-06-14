﻿using NeuronPasswordToolkit.Interfaces;
using NeuronPasswordToolkit.ViewModels;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace NeuronPasswordToolkit.Models
{
    public class GeneratorModel : ViewModelBase
    {
        public List<string> StringQuestion
        {
            get
            {
                return new List<string>
                {
                    "What was the color of the walls in your room when you were younger?",
                    "Who is your favorite band/artist?",
                    "What band/artist is your guilty pleasure?",
                    "In a few words, describe your most embarrassing memory.",
                    "What was the name of the road you lived on when you were younger?",
                    "What is the full name of your favorite fictional character?",
                    "Where did you go for your first vacation?",
                    "Where were you when you had your first kiss?",
                    "What is/was your nickname?",
                    "What is the name of your favorite store?",
                    "What is your mother's maiden name?",
                    "What is the title of your favorite book?",
                    "What city did you get lost in?",
                    "What is the birth month of your favorite family member?",
                    "What was the name of your elementary school?",
                    "Who is your favorite superhero?",
                    "What is your oldest sibling's middle name?",
                    "In what town was your High School located?",
                    "What was your favorite teacher's last name?",
                    "What is the last name of the teacher who gave you your first failing grade?",
                    "What was the name of your first stuffed animal?",
                    "Who is your role model?",
                    "What was your childhood best friend's last name?",
                    "What is the name of a college you applied to but didn't attend?",
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
                    "What year was your favorite album released? How many members did the band have at that time?",
                    "Pick 5 numbers, 1 through 60, to play the lottery with for the rest of your life.",
                    "What is your shoe size and lucky number? (Enter as one number)",
                    "How old were you when you moved into your own apartment/house? What was the postal code there?",
                    "What year did you graduate from high school? How many people were in your graduating class?",
                    "If you were swarmed by an army of duck-sized horses, how many would it take to overwhelm you? Be confident!",
                    "What was the postal code of the area you lived in when you were in 5th grade?",
                    "What was the most expensive thing you remember purchasing? (Round to the nearest dollar)",
                    "What was the model year of your first car? How many times did you stain the interior?",
                    "At what time of day do you usually eat your first meal of the day? What about your last meal?",
                    "What age did you start dating? What age are you now? (Enter as one number)",
                    "What date is significant to you?"
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
    }
}
