
using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class AmbienteProfile : Profile
    {
        public AmbienteProfile()
        {
            CreateMap<Ambiente, AmbienteDtoRequest>().ReverseMap();          
            CreateMap<Ambiente, AmbienteDtoResponse>();
        }
    }
}