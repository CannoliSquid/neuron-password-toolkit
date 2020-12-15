using NeuronPasswordToolkit.Models;
using NeuronPasswordToolkit.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeuronPasswordToolkit.Views
{
    /// <summary>
    /// Interaction logic for GeneratorView.xaml
    /// </summary>
    public partial class GeneratorView : UserControl
    {
        public GeneratorView()
        {
            InitializeComponent();
            DataContext = new GeneratorModel();
        }

        private void FormSpecCharsSpecific_Checked(object sender, RoutedEventArgs e)
        {
            FormSpecCharsTB.IsEnabled = true;
            //vm.SpecialCharacterSet = "specific";
        }

        private void FormSpecCharsDefault_Checked(object sender, RoutedEventArgs e)
        {
            FormSpecCharsTB.IsEnabled = false; 
            //vm.SpecialCharacterSet = "default";
        }

        private void FormGenerateRandomButton_Click(object sender, RoutedEventArgs e)
        {
            //vm.CreateFinalProduct();
        }

        private void FormGenerateFamiliarButton_Click(object sender, RoutedEventArgs e)
        {
            //vm.CreateFinalProduct();
        }

        /*private void GetFormDetails()
        {
            string answer1, answer2, sCharPool, sChars;
            int length;
            try
            {
                if (FormMainInputA1TB.Text != "" && FormMainInputA1TB.Text != null && FormMainInputA2TB.Text != "" && FormMainInputA2TB.Text != null)
                {
                    try
                    {
                        if (specChars == "specific" && FormSpecCharsTB.Text != null && FormSpecCharsTB.Text != "")
                        {
                            answer1 = FormMainInputA1TB.Text;
                            answer2 = FormMainInputA2TB.Text;
                            sCharPool = FormSpecCharsTB.Text;
                            sChars = sCharPool.Replace(" ", String.Empty);
                            length = (int)FormLengthInputLengthSelect.SelectedItem;

                            //return (answer1, answer2, sCharPool, length);
                        }
                        else if (specChars == "default")
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
                        MessageBox.Show("Invalid Special Character Pool Selection", ex.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Answer Text", ex.ToString());
            }
            

        }*/
    }
}

/*
 * string spchar1 = checkCtrlr.isDSCCheckedFamiliar().Item1;
            string spchar2 = checkCtrlr.isDSCCheckedFamiliar().Item2;
            string spchar3 = checkCtrlr.isDSCCheckedFamiliar().Item3;
            string specChars = checkCtrlr.isDSCCheckedFamiliar().Item4;*/