using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class WebView_Javascript : Page
    {
        public WebView_Javascript()
        {
            this.InitializeComponent();

            this.Loaded += WebView_Javascript_Loaded;
        }

        async void WebView_Javascript_Loaded(object sender, RoutedEventArgs e)
        {
            //this.web.Navigate(new Uri("http://www.google.com.br"));

            this.web.NavigateToString("<html><head><script>function sum(a,b){return a + b;}</script><body style='background-color:darkgray'><h1>IBGE</h1></body></html>");
            
            await Task.Delay(TimeSpan.FromSeconds(5));

             var result = await this.web.InvokeScriptAsync("sum", new string[]{"10", "10"});

             int a = 0;
            
        }
    }
}
