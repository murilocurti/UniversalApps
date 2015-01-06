using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
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
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();

            this.Loaded += Settings_Loaded;
        }

        private ApplicationDataContainer localSettings =
            ApplicationData.Current.LocalSettings;
        private ApplicationDataContainer roamingSettings =
            ApplicationData.Current.RoamingSettings;

        void Settings_Loaded(object sender, RoutedEventArgs e)
        {
            var settings = localSettings;
            string key = "plano";

            Plano p = new Plano();
            p.Nome = "Gold";

            settings.Values[key] = "teste";
            //settings.Values[key] = p;

            var x = settings.Values[key].ToString();
            Plano p2 = (Plano)settings.Values[key];

        }
    }

    public class  Plano
    {
        public string Nome { get; set; }
    }
}
