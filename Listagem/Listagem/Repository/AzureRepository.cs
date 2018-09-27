using Listagem.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Listagem.Repository
{
    public class AzureRepository
    {
        private IMobileServiceClient Client;
        private IMobileServiceTable<Lista> Table;

        public AzureRepository()
        {
            string MyAppServiceURL = "https://apppucminas2018.azurewebsites.net/";
            Client = new MobileServiceClient(MyAppServiceURL);
            Table = Client.GetTable<Lista>();
        }

        public async Task<IEnumerable<Lista>> RetonarAll()
        {
            var empty = new Lista[0];
            try
            {
                return await Table.ToEnumerableAsync();
            }
            catch (Exception)
            {
                return empty;
            }
        }
        public async void Insert(Lista Lista)
        {
            await Table.InsertAsync(Lista);
        }

        public async Task Update(Lista Lista)
        {
            await Table.UpdateAsync(Lista);
        }

        public async void Delete(Lista Lista)
        {
            await Table.DeleteAsync(Lista);
        }

        public async Task<Lista> Find(string id)
        {
            var itens = await Table.Where(i => i.Id == id).ToListAsync();
            return (itens.Count > 0) ? itens[0] : null;
        }

        public async Task<Lista> GetFirst()
        {
            var itens = await Table.ToListAsync();
            return (itens.Count > 0) ? itens[0] : null;
        }
    }
}
