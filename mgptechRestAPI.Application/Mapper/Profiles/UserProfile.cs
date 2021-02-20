using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDtoRequest>().ReverseMap();
            CreateMap<User, UserDtoResponse>();
        }
    }
}