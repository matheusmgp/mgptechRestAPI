using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Application.Mapper.Profiles
{
    public class AgendaProfile : Profile
    {
        public AgendaProfile()
        {
            CreateMap<Agenda, AgendaDtoRequest>().ReverseMap();
            CreateMap<Agenda, AgendaDtoResponse>();
        }
    }
}