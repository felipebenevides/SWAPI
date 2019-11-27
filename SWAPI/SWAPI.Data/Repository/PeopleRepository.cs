using SWAPI.Data.Context;
using SWAPI.Domain.Interfaces.Interface;
using SWAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI.Data.Repository
{
    public class PeopleRepository : Repository<People>, IPeopleRepository
    {
        public PeopleRepository(SWAPIContext context) : base(context)
        {

        }
    }
}
