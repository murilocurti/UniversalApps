using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using X;

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
using System.Threading.Tasks;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_Apps_01.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CS : Page
    {
        public CS()
        {
            this.InitializeComponent();

            var data = new List<double>();

            data.Add(0);
            data.Add(1);
            data.Add(3);

            bool has3 = false;

            foreach (var item in data)
            {
                var xx = item + 1;

                if(item == 3)
                { 
                    has3 = true; 
                }
            }

            var query = from item in data
                        where item == 3
                            select item;

            var query2 = data.Where(x => x == 3);


            this.Loaded += CS_Loaded;
        }
        public async Task Salvar(string filename)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
        }
        public async Task<int> Soma(int a, int b)
        {
            return a + b;
        }
        async void CS_Loaded(object sender, RoutedEventArgs e)
        {
            await LeArquivo("file.txt");
            await LeArquivo("file1txt");
            await new MessageDialog("mensagem 1").ShowAsync();
            await LeArquivo("file2.txt");
            var resultado = await Soma(5, 5);

            Salvar("file2.txt");
            await Salvar("file2.txt");
            int a = 0;
        }

        

        public async Task LeArquivo(string filename)
        {
            var data = new List<double>();

            data.Add(0);
            data.Add(1);
            data.Add(3);

            var query = from item in data
                        where item == 3
                        select item;

            //default(T);

            var query2 = data.Where(x => x == 3).FirstOrDefault();
            var query22 = data.Where(x => x == 3).First();

           
            var query3 = data.Where(x => x == 3).SingleOrDefault();
            var query32 = data.Where(x => x == 3).Single();

            var query4 = data.Where(x => x == 3).ToList();

            int count = data.Count(x => x == 3);

            int z = 0;
            int xx;

            int? xy = null;
            xy = 0;


            if(xy == null)
            {

            }

            if(xy != null && xy.HasValue)
            {

            }

            z = xy.Value;

        }

    }
}

namespace X
{
    public static class Extension
    {
        public static DateTime Soma(this DateTime date, TimeSpan d)
        {
            return date.Add(d);
        }
    }
}
