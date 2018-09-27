using Listagem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Listagem.Services.Interfaces
{
    public interface lListaService
    {
        void Inserir(Lista lista);
        Task<IEnumerable<Lista>> ObterTodos();
    }
}
