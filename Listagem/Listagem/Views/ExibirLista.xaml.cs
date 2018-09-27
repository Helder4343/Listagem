using CommonServiceLocator;
using Listagem.Repository;
using Listagem.ViewsModels;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Listagem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExibirLista : ContentPage
    {
       
        public ExibirLista ()
		{
            InitializeComponent();
            //var viewModel = ServiceLocator.Current.GetInstance<ClientesPageViewModel>();
            var viewModel = new ClientesPageViewModel();
            BindingContext = viewModel;
        }
    }
}