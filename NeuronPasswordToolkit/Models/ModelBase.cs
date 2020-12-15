using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NeuronPasswordToolkit.Models
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);
        protected void RaisePropertyChanged(string propertyName) => OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
    }
}
