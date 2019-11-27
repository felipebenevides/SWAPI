using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Application.Services;
using SWAPI.Application.ViewModels;
using SWAPI.Domain.Interfaces.Service;

namespace SWAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SWAPIController : Controller
    {
        private readonly IPeopleAppService _peopleAppService;

        public SWAPIController(IPeopleAppService peopleAppService)
        {
            _peopleAppService = peopleAppService;
        }

        public async Task<List<PeopleViewModel>> ObterPersonagens()
        {
            return await _peopleAppService.ObterPersonagens();
        }


    }
}