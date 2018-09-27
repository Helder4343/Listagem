using Listagem.Models;
using Listagem.Repository;
using Listagem.ViewsModels.Base;
using Listagem.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Listagem.Services.Interfaces;

namespace Listagem.ViewsModels.Base
{   
    public class ListaPageViewMode : ViewModelBase
    {
        private readonly ListaService ListaService;
        //private readonly lListaService ListaService;
        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                SetProperty(ref nome, value);
            }
        }

        private string end;
        public string End
        {
            get { return end; }
            set
            {
                SetProperty(ref end, value);
            }
        }

        private double telefone;
        public double Telefone
        {
            get { return telefone; }
            set
            {
                SetProperty(ref telefone, value);
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                SetProperty(ref email, value);
            }
        }

        private Lista lista;
        public Lista Lista
        {
            get { return lista; }
            set
            {
                SetProperty(ref lista, value);
            }
        }

        public Command GravarCommand { get; }
        public Command LimparCommand { get; }

        public ListaPageViewMode()
        {
            GravarCommand = new Command(ExecuteGravarCommand);
            LimparCommand = new Command(ExecuteLimparCommand);
            Lista = new Lista();
            ListaService = new ListaService();
            //ListaService = listaaux;
        }

        private void ExecuteLimparCommand()
        {
            Nome = string.Empty;
            End = string.Empty;
            Email = string.Empty;
            Telefone = 0;
        }

        private async void ExecuteGravarCommand()
        {
            //--Referencia as variaveis
            Lista.Nome = Nome;
            Lista.Telefone = Telefone;
            Lista.Email = Email;
            Lista.End = End;
            //--Inseri lista no objeto
            ListaService.Inserir(Lista);

            await App.Current.MainPage.DisplayAlert("Sucesso", "Lista Gravada como sucesso!", "Ok");
            //--Executa comando de limpar as variaveis
            ExecuteLimparCommand();
        }
    }
}
