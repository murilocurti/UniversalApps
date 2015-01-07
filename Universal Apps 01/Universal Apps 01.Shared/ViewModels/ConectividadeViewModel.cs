using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Universal_Apps_01.Common;
using Windows.ApplicationModel.Core;
using Windows.Networking.Connectivity;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace Universal_Apps_01.ViewModels
{
    public class ConectividadeViewModel : ViewModelBase
    {
        public ConectividadeViewModel()
        {
            this.LoadCommand = new RelayCommand(Load);

            NetworkInformation.NetworkStatusChanged += NetworkInformation_NetworkStatusChanged;
        }

        async void NetworkInformation_NetworkStatusChanged(object sender)
        {
        

            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(
                CoreDispatcherPriority.Normal, 
                () =>
            {
                this.IsConnected = this.Conectado();
                this.Mensagem = this.IsConnected ? "Conectado" : "Sem conexão";
         
            });

          
        }

         public ICommand LoadCommand { get; set; }

         private async void Load()
         {
             this.IsConnected = this.Conectado();

             this.Mensagem = this.IsConnected ? "Conectado" : "Sem conexão";
         }

        private bool Conectado()
         {
             ConnectionProfile profile = NetworkInformation.GetInternetConnectionProfile();

            if(profile == null)
            {
                return false;
            }

            var level = profile.GetNetworkConnectivityLevel();

            return level == NetworkConnectivityLevel.InternetAccess;
         }
       

        private bool _isConnected;

        public bool IsConnected
        {
            get { return this._isConnected; }
            set
            {
                this._isConnected = value;
                this.Set("IsConnected");
            }
        }

       

        private string _mensagem;

        public string Mensagem
        {
            get { return this._mensagem; }
            set
            {
                this._mensagem = value;
                this.Set("Mensagem");
            }
        }
    }
}
