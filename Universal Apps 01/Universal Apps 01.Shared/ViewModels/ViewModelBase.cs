using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Universal_Apps_01.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public void Set(string property)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
