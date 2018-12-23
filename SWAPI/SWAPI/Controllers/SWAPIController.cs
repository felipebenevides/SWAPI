using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Domain.Interfaces.Service;

namespace SWAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SWAPIController : Controller
    {
        private readonly IPeopleService _peopleService;

        public SWAPIController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        //public async Task<List<People>> ObterPersonagens()
        //{
        //    return _peopleService.ObterPersonagens();
        //}


    }
}