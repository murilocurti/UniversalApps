using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Universal_Apps_01.Common;

namespace Universal_Apps_01.ViewModels
{
    public class Indicadores_ProgressoViewModel : ViewModelBase
    {
        public Indicadores_ProgressoViewModel()
        {
            this.SalvarCommand = new RelayCommand(Salvar);
            this.LoadCommand = new RelayCommand(Load);

        }

         public ICommand LoadCommand { get; set; }

         private async void Load()
         {
             this.IsEmProgresso = true;
             this.MensagemDeProgresso = "Inicilizando...";
             await Task.Delay(TimeSpan.FromSeconds(3));
             this.IsEmProgresso = false;
         }

        public ICommand SalvarCommand { get; set; }

        private async void Salvar()
        {
            this.IsEmProgresso = true;

            this.MensagemDeProgresso = "Salvando dados...";

            // processamento, salvar, etc.

            this.ProgressoAtual = 0;

            for (int i = 0; i < 5; i++)
            {
                this.ProgressoAtual += 20;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            this.IsEmProgresso = false;
        }

        private bool _isEmProgresso;

        public bool IsEmProgresso
        {
            get { return this._isEmProgresso; }
            set
            {
                this._isEmProgresso = value;
                this.Set("IsEmProgresso");
            }
        }

        private double _progressoAtual;

        public double ProgressoAtual
        {
            get { return this._progressoAtual; }
            set
            {
                this._progressoAtual = value;
                this.Set("ProgressoAtual");
            }
        }

        private string _mensagemDeProgresso;

        public string MensagemDeProgresso
        {
            get { return this._mensagemDeProgresso; }
            set
            {
                this._mensagemDeProgresso = value;
                this.Set("MensagemDeProgresso");
            }
        }
    }
}
