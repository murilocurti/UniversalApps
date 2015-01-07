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
    public class MiscViewModelSampleData : MiscViewModel
     {
        public MiscViewModelSampleData()
        {
            this.Mensagem = "Mensagem 1 bla bla bla";
            this.Mensagem2 = "Mensagem 2 la la la";

            this.Lista = new List<string>();
            this.Lista.Add("Item 1");
            this.Lista.Add("Item 2");
            this.Lista.Add("Item 3");
            this.Lista.Add("Item 4");
            this.Lista.Add("Item 5");
        }

     }

    public class MiscViewModel : ViewModelBase
    {
        public MiscViewModel()
        {
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

        private string _mensagem2;

        public string Mensagem2
        {
            get { return this._mensagem2; }
            set
            {
                this._mensagem2 = value;
                this.Set("Mensagem2");
            }
        }

        private List<string> _lista;

        public List<string> Lista
        {
            get { return this._lista; }
            set
            {
                this._lista = value;
                this.Set("Lista");
            }
        }
    }
}
