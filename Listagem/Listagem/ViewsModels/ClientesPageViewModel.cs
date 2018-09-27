using Listagem.Models;
using Listagem.Services;
using Listagem.Services.Interfaces;
using Listagem.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Listagem.ViewsModels
{
    public class ClientesPageViewModel : ViewModelBase
    {
        //private readonly lListaService ListaService;
        private readonly ListaService ListaService;

        public ObservableCollection<Lista> Listas { get; set; }

       /* public ClientesPageViewModel(lListaService listaService)
        {
            ListaService = listaService;
            Listas = new ObservableCollection<Lista>();
            ObterCliestes();
            AtualizarDadosCommand = new Command(ExecuteAtualizarDadosCommand);
        }*/

        public ClientesPageViewModel()
        {
            ListaService = new ListaService();
            Listas = new ObservableCollection<Lista>();
            ObterCliestes();
            AtualizarDadosCommand = new Command(ExecuteAtualizarDadosCommand);
        }

        private async void ExecuteAtualizarDadosCommand()
        {
            Atualizando = true;
            await ObterCliestes();
            Atualizando = false;
        }

        private bool atualizando;
        public bool Atualizando
        {
            get { return atualizando; }
            set { SetProperty(ref atualizando, value); }
        }

        private Lista lista;
        public Lista Lista
        {
            get { return lista; }
            set
            {
                SetProperty(ref lista, value);
                if (lista != null)
                {
                    App.Current.MainPage.DisplayAlert("Lista", lista.Nome, "ok");
                }
            }
        }
        public Command AtualizarDadosCommand { get; }

        private async Task ObterCliestes()
        {
            var listas = await ListaService.ObterTodos();
            //--Valida se lista está vazia
            if (Listas.Count > 0)
            {
                Listas.Clear();
            }
            //--Add itens na lista
            foreach (var lista in listas)
            {
                Listas.Add(lista);
            }
        }
    }
}
