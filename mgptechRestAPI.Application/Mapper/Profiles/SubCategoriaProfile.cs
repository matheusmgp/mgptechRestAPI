using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class SubCategoriaProfile : Profile
    {
        public SubCategoriaProfile()
        {
            CreateMap<SubCategoria, SubCategoriaDtoRequest>().ReverseMap();
            CreateMap<SubCategoria, SubCategoriaDtoResponse>();
        }
    }
}