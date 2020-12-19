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
    }
}