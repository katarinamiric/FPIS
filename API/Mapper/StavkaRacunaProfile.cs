using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Entities;
using AutoMapper;

namespace API.Mapper
{
    public class StavkaRacunaProfile : Profile
    {
        public StavkaRacunaProfile()
        {
            CreateMap<StavkaRacunaOsiguranja, StavkaRacunaDto>()
                .ReverseMap();

            CreateMap<RacunOsiguranja, RacunDto>()
                .ForPath(dest => dest.Stavke, opt => opt.MapFrom(src => src.StavkeRacunaOsiguranja))
                .ReverseMap();
        }
    }
}