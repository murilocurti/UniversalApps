using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Universal_Apps_01.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_Apps_01.Views
{
    

    public sealed partial class DataBinding : Page
    {
        private ViewModel vm = new ViewModel();

        public DataBinding()
        {
            this.InitializeComponent();

            vm.Checado = false;
            vm.Valor = 37;

            this.DataContext = vm;

            ObservableCollection<string> lista = new ObservableCollection<string>();

            lista.Add((this.vm.Valor + 1).ToString());
            lista.Add((this.vm.Valor + 2).ToString());
            lista.Add((this.vm.Valor + 3).ToString());

            this.vm.Lista = lista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.vm.Valor += 10;

            this.vm.Lista.Add(this.vm.Lista.Count.ToString());
        }
    }
}
