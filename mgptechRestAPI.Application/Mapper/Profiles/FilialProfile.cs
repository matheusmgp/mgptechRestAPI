using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class FilialProfile : Profile
    {
        public FilialProfile()
        {
            CreateMap<Filial, FilialDtoRequest>().ReverseMap();
            CreateMap<Filial, FilialDtoResponse>();
        }
    }
}