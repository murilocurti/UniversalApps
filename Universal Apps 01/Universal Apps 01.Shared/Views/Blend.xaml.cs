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
    public sealed partial class Blend : Page
    {
        public Blend()
        {
            this.InitializeComponent();

            //Atrasa o início da animação em 2 segundos
            this.Storyboard1.BeginTime = TimeSpan.FromSeconds(2);

            this.Storyboard1.Completed += Storyboard1_Completed;

            this.Storyboard1.Begin();
        }

        async void Storyboard1_Completed(object sender, object e)
        {
            //Só será ativado se a animação não estiver com RepeatBehavior = Forever
            await new MessageDialog("Animação finalizada!").ShowAsync();
        }
    }
}
