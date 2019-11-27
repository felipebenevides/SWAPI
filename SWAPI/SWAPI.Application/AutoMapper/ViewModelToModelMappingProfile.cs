using AutoMapper;
using SWAPI.Application.ViewModels;
using SWAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI.Application.AutoMapper
{
    public class ViewModelToModelMappingProfile :Profile
    {
        public ViewModelToModelMappingProfile()
        {
            CreateMap<PeopleViewModel,People>();
        }
    }
}
