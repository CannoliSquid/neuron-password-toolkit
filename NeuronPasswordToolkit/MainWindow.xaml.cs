using MaterialDesignExtensions.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xaml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NeuronPasswordToolkit.Views;

namespace NeuronPasswordToolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MaterialWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //Set AboutPage as home screen.
            AboutView about = new AboutView();
            ContentControl.Content = about;
        }

        private void GeneratorMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Set HomePage as home screen.
            GeneratorView generate = new GeneratorView();
            ContentControl.Content = generate;
        }

        private void HelpMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Set HomePage as home screen.
            HelpView help = new HelpView();
            ContentControl.Content = help;
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Set AboutPage as home screen.
            AboutView about = new AboutView();
            ContentControl.Content = about;
        }
    }
}
