using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    class CanalComunicacaoProfile : Profile
    {
        public CanalComunicacaoProfile()
        {
            CreateMap<CanalComunicacao, CanalComunicacaoDtoRequest>().ReverseMap();
            CreateMap<CanalComunicacao, CanalComunicacaoDtoResponse>();
        }
    }
}
