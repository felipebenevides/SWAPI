using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SWAPI.Application.ViewModels;
using SWAPI.Domain.Interfaces.Service;
using SWAPI.Domain.Models;

namespace SWAPI.Application.Services
{
    public class PeopleAppService : IPeopleAppService
    {
        private readonly IPeopleService _peopleService;

        public PeopleAppService(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public void Alterar(PeopleViewModel entity)
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

        public void Incluir(PeopleViewModel entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PeopleViewModel> Listar()
        {
            throw new NotImplementedException();
        }

        public PeopleViewModel Obter(object id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PeopleViewModel>> ObterPersonagens()
        {
            return Mapper.Map<Task<List<PeopleViewModel>>>(_peopleService.ObterPersonagens());
        }
    }
}
