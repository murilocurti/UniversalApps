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
    public sealed partial class MainPage : Page
    {
        private Dictionary<string, Type> pages = new Dictionary<string, Type>();

        public MainPage()
        {
            this.InitializeComponent();


            pages.Add("01 - Mesmo Xaml", typeof(Mesmo_Xaml));
            pages.Add("02 - Xaml Específico", typeof(Xaml_Especifico));
            pages.Add("03 - Mesma Api / Mesmo Comportamento", typeof(Mesma_Api_Mesmo_Comportamento));
            pages.Add("04 - Mesma Api / Comportamento Diferente", typeof(Mesma_Api_Comportamento_Diferente));
            pages.Add("05 - Controles Container", typeof(Controles_Container));
            pages.Add("06 - UserControls", typeof(UserControls));
            pages.Add("07 - Resources", typeof(Resources));
            pages.Add("08 - DataBinding", typeof(DataBinding));

            pages.Add("09 - C#", typeof(CS));
            pages.Add("10 - Arquivos", typeof(Arquivos));
            pages.Add("11 - Settings", typeof(Settings));
            pages.Add("12 - Serviços", typeof(Servicos));

            
            this.DataContext = pages;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(this.pages[e.ClickedItem.ToString()]);
        }
    }
}
