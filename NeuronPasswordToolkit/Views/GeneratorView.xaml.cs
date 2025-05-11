using NeuronPasswordToolkit.Controllers;
using NeuronPasswordToolkit.Interfaces;
using NeuronPasswordToolkit.Models;
using NeuronPasswordToolkit.ViewModels;
using System;
using System.Collections.Generic;
using System.Security;
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
        public static string ViewName = "Password Generator";
        public GeneratorView()
        {
            InitializeComponent();
            DataContext = new GeneratorViewModel();
        }

        private void FormSpecCharsSpecific_Checked(object sender, RoutedEventArgs e)
        {
            FormSpecCharsTB.IsEnabled = true;
        }

        private void FormSpecCharsDefault_Checked(object sender, RoutedEventArgs e)
        {
            FormSpecCharsTB.IsEnabled = false;
        }

        private void FormGenerateRandomButton_Click(object sender, RoutedEventArgs e)
        {
            FormOutputPB.Password = "NotTheRealPassword!";
        }

        private void FormGenerateFamiliarButton_Click(object sender, RoutedEventArgs e)
        {
            FormOutputPB.Password = "NotTheRealPassword!";
        }

        private void FormOutputSaveButton_Click(object sender, RoutedEventArgs e)
        {
            FormOutputPB.Password = null;
        }
    }
}