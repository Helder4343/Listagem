using Listagem.Domain.Listas.Repository;
using Listagem.Infra.Data.Repository;
using Listagem.Services;
using Listagem.Services.Interfaces;
using System;
using Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Listagem
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<ListalRepository, ListaRepository>();
            unityContainer.RegisterType<lListaService, ListaService>();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
