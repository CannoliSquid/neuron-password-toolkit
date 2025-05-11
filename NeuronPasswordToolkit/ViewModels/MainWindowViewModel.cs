using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NeuronPasswordToolkit.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private string _currentViewName { get; set; }

        public string CurrentViewName
        {
            get { return _currentViewName; }
            set { _currentViewName = value; OnPropertyChanged(); }
        }

        private UserControl _currentView;

        public UserControl CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
    }
}
