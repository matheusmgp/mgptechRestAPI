using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Service.Services
{
    public class AgendaService : BaseService<Agenda>, IAgendaService
    {
        private readonly IAgendaRepository _agendaRepository;

        public AgendaService(IAgendaRepository agendaRepository) : base(agendaRepository)
        {
            _agendaRepository = agendaRepository;
        }
    }
}