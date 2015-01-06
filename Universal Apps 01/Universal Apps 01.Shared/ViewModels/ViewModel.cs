using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Universal_Apps_01.Common;

namespace Universal_Apps_01.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            this.Mais10Command = new RelayCommand(Mais10);
        }

        public ICommand Mais10Command { get; set; }

        private void Mais10()
        {
            this.Valor += 10;
            this.Checado = !this.Checado;
        }

        private bool checkado;

        public bool Checado
        {
            get { return this.checkado; }
            set
            {
                this.checkado = value;
                this.Set("Checado");
            }
        }

        private double valor;
        public double Valor
        {
            get { return this.valor; }
            set
            {
                this.valor = value;
                this.Set("Valor");
            }
        }

        private ObservableCollection<string> lista = new ObservableCollection<string>();

        public ObservableCollection<string> Lista
        {
            get { return this.lista; }
            set 
            { 
                this.lista = value;
                this.Set("Lista");
            }
        }

        public void teste() { }
    }
}
