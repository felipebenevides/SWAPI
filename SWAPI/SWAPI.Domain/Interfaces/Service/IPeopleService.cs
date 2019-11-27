using SWAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI.Domain.Interfaces.Service
{
    public interface IPeopleService : IService<People>
    {
        Task<List<People>> ObterPersonagens();
    }
}
