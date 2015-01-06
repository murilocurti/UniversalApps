using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mesmo_Xaml : Page
    {
        public Mesmo_Xaml()
        {
            this.InitializeComponent();

            //Grid g = new Grid();
            //root.Children.Add(g);
            Button b = new Button();
            b.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
            b.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
            b.Content = "IBGE";

            this.content.Children.Add(b);

            this.SizeChanged += Mesmo_Xaml_SizeChanged;


        }

        void Mesmo_Xaml_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }
    }
}
