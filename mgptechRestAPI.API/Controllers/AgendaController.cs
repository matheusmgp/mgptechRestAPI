using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace mgptechRestAPI.API.Controllers
{
    [Route("api/agendas")]
    [ApiController]
    
    public class AgendaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAgendaService _igendaService;
        public AgendaController(IMapper mapper, IAgendaService iAgendaService)
        {
            _mapper = mapper;
            _igendaService = iAgendaService;
        }
        
        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AgendaDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<AgendaDtoResponse>>> GetAll()
        {
            var agendas = await  _igendaService.FindAllAsync();

            if (agendas == null) return NotFound("Não foi possivel bsucar os dados.");

            var agendaDtoResponse = _mapper.Map<IEnumerable<AgendaDtoResponse>>(agendas);
            return this.StatusCode(StatusCodes.Status200OK, agendaDtoResponse);
        }
               
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AgendaDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AgendaDtoResponse>> GetById(int id)
        {
            var agenda = await _igendaService.FindByIdAsync(id);

            if (agenda == null) return NotFound("Não foi possivel bsucar os dados.");

            var agendaDtoResponse = _mapper.Map<AgendaDtoResponse>(agenda);

            return this.StatusCode(StatusCodes.Status200OK, agendaDtoResponse);
        }
               
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Role))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Agenda>> Post([FromBody] AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);

            var isCreated = await _igendaService.Create(agenda);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = agenda.Id }, agenda);
        }
                
        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Role))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Agenda>> Put(int id, [FromBody] AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);
            var isUpdated = await _igendaService.Update(id, agenda);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(agenda);
        }
        
    }
}