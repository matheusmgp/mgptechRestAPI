using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDtoRequest>().ReverseMap();
            CreateMap<Role, RoleDtoResponse>();
        }
    }
}