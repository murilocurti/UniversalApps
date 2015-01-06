using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
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
    
#if WINDOWS_PHONE_APP
    public sealed partial class Arquivos : Page, IFileOpenPickerContinuable
    
#else
    public sealed partial class Arquivos : Page

#endif
    {
        public Arquivos()
        {
            this.InitializeComponent();

            this.Loaded += Arquivos_Loaded;
        }

        private string fileName = "file.txt";

        private StorageFolder localFolder = ApplicationData.Current.LocalFolder;
        private StorageFolder roamingFolder = ApplicationData.Current.RoamingFolder;
        private StorageFolder tempFolder = ApplicationData.Current.TemporaryFolder;
        private StorageFolder documentsFolder = 
            KnownFolders.DocumentsLibrary;

        async void Arquivos_Loaded(object sender, RoutedEventArgs e)
        {
            var folder = documentsFolder;
            
            StorageFile file = await folder.CreateFileAsync(fileName,
                CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, DateTime.Now.ToString());

            string text = await FileIO.ReadTextAsync(file);

            int a = 0;
        }

#if WINDOWS_PHONE_APP
        public async void ContinueFileOpenPicker(Windows.ApplicationModel.Activation.FileOpenPickerContinuationEventArgs args)
        {
            if (args.Files.Count > 0)
            {
                await this.ReadFile(args.Files[0]);
            }
        }
#endif

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var filters = new string[] { ".txt", ".xml" };

            FileOpenPicker picker = new FileOpenPicker() { 
                    SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
                    ViewMode = PickerViewMode.Thumbnail };

            //foreach (string filter in filters)
            //{
            //    picker.FileTypeFilter.Add(filter);
            //}

            picker.FileTypeFilter.Add(".txt");

#if WINDOWS_PHONE_APP
            picker.PickSingleFileAndContinue();
#else
            await ReadFile(await picker.PickSingleFileAsync());
#endif
        }

        private async Task ReadFile(StorageFile file)
        {
            string text = await FileIO.ReadTextAsync(file);
            await new MessageDialog(text).ShowAsync();
        }
    }
}
