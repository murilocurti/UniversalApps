using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class Ciclo_de_Vida : Page
    {
        public Ciclo_de_Vida()
        {
            this.InitializeComponent();

            this.Loaded += Ciclo_de_Vida_Loaded;

            App.Current.Suspending += Current_Suspending;
            App.Current.Resuming += Current_Resuming;
        }

        void Current_Resuming(object sender, object e)
        {
            object value = this.Get("txt");

            if (value != null)
            {
                this.txt.Text = value.ToString();
                this.Set("txt", null);
            }
        }

        void Current_Suspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
        {
            this.Set("txt", this.txt.Text);
        }

        void Ciclo_de_Vida_Loaded(object sender, RoutedEventArgs e)
        {
            object value = this.Get("txt");

            if (value != null)
            {
                this.txt.Text = value.ToString();
                this.Set("txt", null);
            }
        }

        private ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;

        private void Set(string key, object value)
        {
            settings.Values[key] = value;
        }

        private object Get(string key)
        {
            return settings.Values[key];
        }
    }
}
