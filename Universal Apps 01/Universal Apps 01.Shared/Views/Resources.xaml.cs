using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Resources : Page
    {
        public Resources()
        {
            this.InitializeComponent();

            this.lista.Items.Add("T1");
            this.lista.Items.Add("T2");
            this.lista.Items.Add("T3");
            this.lista.Items.Add("T5");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MessageDialog("teste").ShowAsync();
        }
    }
}
