using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
    public sealed partial class Servicos : Page
    {
        public Servicos()
        {
            this.InitializeComponent();

            this.Loaded += Servicos_Loaded;
        }

        private StorageFolder localFolder = ApplicationData.Current.LocalFolder;

        async void Servicos_Loaded(object sender, RoutedEventArgs e)
        {
            string echoUri = "http://echo.jsontest.com/key1/value1/key2/value2/key3/value3";

            HttpClient http = new HttpClient();
            var response = await http.GetAsync(echoUri);

            if(response.IsSuccessStatusCode)
            {
                string str = await response.Content.ReadAsStringAsync();
            }

            var str2 = await http.GetStringAsync(echoUri);

            Echo echo = JsonConvert.DeserializeObject<Echo>(str2);

            string json = JsonConvert.SerializeObject(echo);

            var folder = localFolder;

            string fileName = "echo.json";
            StorageFile file = await folder.CreateFileAsync(fileName,
                CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(file, json);

            string text = await FileIO.ReadTextAsync(file);

            int a = 0;


        }
    }
}
