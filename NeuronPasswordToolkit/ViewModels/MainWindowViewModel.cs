using NeuronPasswordToolkit.Helpers;
using NeuronPasswordToolkit.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NeuronPasswordToolkit.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Binding Properties
        private string _currentViewName { get; set; }

        public string CurrentViewName
        {
            get { return _currentViewName; }
            set { _currentViewName = value; OnPropertyChanged(); }
        }

        private UserControl _mainView;

        public UserControl MainView
        {
            get { return _mainView; }
            set { _mainView = value; OnPropertyChanged(); }
        }

        private bool _menuOpen { get; set; }

        public bool MenuOpen
        {
            get { return _menuOpen; }
            set { _menuOpen = value; OnPropertyChanged(); }
        }
        #endregion

        #region Commands
        public ICommand GeneratorMenuItemClick { get; set; }
        public ICommand HelpMenuItemClick { get; set; }
        public ICommand AboutMenuItemClick { get; set; }
        public ICommand StrengthCheckMenuItemClick { get; set; }
        //public ICommand CloseSideMenu { get; set; }
        #endregion

        public MainWindowViewModel()
        {
            GeneratorMenuItemClick = new RelayCommand(o => GeneratorMenuItem_Click());
            HelpMenuItemClick = new RelayCommand(o => HelpMenuItem_Click());
            AboutMenuItemClick = new RelayCommand(o => AboutMenuItem_Click());
            StrengthCheckMenuItemClick = new RelayCommand(o => StrengthCheckMenuItem_Click());
            //CloseSideMenu = new RelayCommand(o => CloseMenu());

            AboutMenuItem_Click();
        }

        private void GeneratorMenuItem_Click()
        {
            //Set HomePage as home screen.
            GeneratorView generate = new GeneratorView();
            ChangeWindowContent(generate, GeneratorView.ViewName);
            CloseMenu();
        }

        private void HelpMenuItem_Click()
        {
            //Set HomePage as home screen.
            HelpView help = new HelpView();
            ChangeWindowContent(help, HelpView.ViewName);
            CloseMenu();
        }

        private void AboutMenuItem_Click()
        {
            //Set AboutPage as home screen.
            AboutView about = new AboutView();
            ChangeWindowContent(about, AboutView.ViewName);
            CloseMenu();
        }

        private void StrengthCheckMenuItem_Click()
        {
            //Set AboutPage as home screen.
            StrengthCheckView strength = new StrengthCheckView();
            ChangeWindowContent(strength, StrengthCheckView.ViewName);
            CloseMenu();
        }

        private void CloseMenu()
        {
            //Close the sidebar/menu after an option is selected.
            //MenuDrawer.IsLeftDrawerOpen = false; This complained about accessibility
            MenuOpen = false; //This should perform the same but be better from a privacy standpoint.
        }

        private void ChangeWindowContent(UserControl view, string name)
        {
            CurrentViewName = name.ToUpper();
            MainView.Content = view;
        }

        //Create method to handle the bindings (content control and view name), accept view as arguement
        /*private void ChangeWindowContent(UserControl view, string name)
        {
            //PageTitleLabel.Content = name.ToUpper();
            //ContentControl.Content = view;
        }*/
    }
}
