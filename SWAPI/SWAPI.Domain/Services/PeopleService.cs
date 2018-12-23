using Newtonsoft.Json;
using SWAPI.Domain.Interfaces.Service;
using SWAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI.Domain.Services
{
    public class PeopleService : IPeopleService
    {
        public void Alterar(People entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public void Excluir(object id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(People entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<People> Listar()
        {
            throw new NotImplementedException();
        }

        public People Obter(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<People>> ObterPersonagens()
        {
            Json personagens = null;
            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://swapi.co/api/people/");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                personagens = JsonConvert.DeserializeObject<Json>(stringResult);
            }

            personagens.results = personagens.results.OrderBy(y => y.Films.Count()).ThenBy(y => y.name).ToList();

            return personagens.results;
        }
    }
}
