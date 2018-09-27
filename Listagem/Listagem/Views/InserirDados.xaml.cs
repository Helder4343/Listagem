using CommonServiceLocator;
using Listagem.Repository;
using Listagem.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Listagem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InserirDados : ContentPage
	{
		public InserirDados ()
		{
			InitializeComponent ();

            var viewModel = new ListaPageViewMode();
            //var viewModel = ServiceLocator.Current.GetInstance<ListaPageViewMode>();
            BindingContext = viewModel;
        }
    }
}