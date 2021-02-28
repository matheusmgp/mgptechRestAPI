using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class UserAuthProfile : Profile
    {
        public UserAuthProfile()
        {
            CreateMap<User, UserAuthDtoRequest>().ReverseMap();
            CreateMap<User, UserAuthDtoResponse>();
        }
    }
}
