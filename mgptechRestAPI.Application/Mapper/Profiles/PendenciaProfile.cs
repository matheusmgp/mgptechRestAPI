using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class PendenciaProfile : Profile
    {
        public PendenciaProfile()
        {
            CreateMap<Pendencia, PendenciaDtoRequest>().ReverseMap();
            CreateMap<Pendencia, PendenciaDtoResponse>();
        }
    }
}