using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class ProcedimentoProfile : Profile
    {
        public ProcedimentoProfile()
        {
            CreateMap<Procedimento, ProcedimentoDtoRequest>().ReverseMap();
            CreateMap<Procedimento, ProcedimentoDtoResponse>();
        }
    }
}