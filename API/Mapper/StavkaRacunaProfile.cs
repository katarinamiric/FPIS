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
                .ForPath(dest => dest.Ugovor, opt => opt.MapFrom(src => src.Ugovor))
                .ForPath(dest => dest.Radnik, opt => opt.MapFrom(src => src.Radnik))
                .ForPath(dest => dest.NacinPlacanja, opt => opt.MapFrom(src => src.NacinPlacanja))
                .ReverseMap();

            CreateMap<UgovorOOsiguranju, UgovorDto>()
                .ReverseMap();
            CreateMap<NacinPlacanja,NacinPlacanjaDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.OpisNacinaPlacanja))
                .ReverseMap();
            CreateMap<Radnik, RadnikDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ImePrezime))
                .ReverseMap();
        }
    }
}
