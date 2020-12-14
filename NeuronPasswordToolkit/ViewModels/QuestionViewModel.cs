using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace NeuronPasswordToolkit.ViewModels
{
    public class QuestionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public QuestionViewModel()
        {
        }

        private bool _IsChecked;
        public bool IsChecked
        {
            get => _IsChecked;
            set
            {
                if (_IsChecked != value)
                {
                    _IsChecked = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsChecked)));
                }
            }
        }

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

        public string SelectedStringQuestion { get; set; }

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

        public string SelectedNumberQuestion { get; set; }
    }
}
