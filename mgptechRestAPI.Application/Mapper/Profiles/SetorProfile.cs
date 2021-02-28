using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class SetorProfile : Profile
    {
        public SetorProfile()
        {
            CreateMap<Setor, SetorDtoRequest>().ReverseMap();
            CreateMap<Setor, SetorDtoResponse>();
        }
    }
}