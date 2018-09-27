using Listagem.Domain.Listas.Repository;
using Listagem.Models;
using Listagem.Repository;
using Listagem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Listagem.Services
{
    public class ListaService : lListaService
    {
        private readonly AzureRepository ListalRepository;
        //private readonly lListalRepository ListalRepository;

        public ListaService()
        {
            ListalRepository = new AzureRepository();
        }        

        public void Inserir( Lista lista)
        {
           ListalRepository.Insert(lista);
        }
        //--Função retorna todos os registros
        public Task<IEnumerable<Lista>> ObterTodos()
        {
            return ListalRepository.RetonarAll();
        }
    }
}
