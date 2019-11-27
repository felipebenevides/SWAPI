using SWAPI.Application.Interfaces;
using SWAPI.Application.ViewModels;
using SWAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI.Application.Services
{
    public interface IPeopleAppService : IAppService<PeopleViewModel>
    {
        Task<List<PeopleViewModel>> ObterPersonagens();
    }
}
