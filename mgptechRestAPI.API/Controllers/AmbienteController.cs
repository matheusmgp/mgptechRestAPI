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
    [Route("api/ambientes")]
    [ApiController]
   
    public class AmbienteController : ControllerBase
    {
        private readonly IAmbienteService _iAmbienteService;
        private readonly IMapper _mapper;

        public AmbienteController(IAmbienteService iAmbienteService, IMapper mapper)
        {
            _mapper = mapper;
            _iAmbienteService = iAmbienteService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AmbienteDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<IEnumerable<AmbienteDtoResponse[]>>> GetAll([FromQuery] bool included = false)
        {
            IEnumerable<Ambiente> ambientes;

            if (included)
            {
                ambientes = await _iAmbienteService.FindAllIncludedAsync();
            }
            else
            {
                ambientes = await _iAmbienteService.FindAllAsync();
            }

            if (ambientes == null) return NotFound("Não foi possivel bsucar os dados.");

            var ambienteDtoResponse = _mapper.Map<IEnumerable<AmbienteDtoResponse>>(ambientes);

            return this.StatusCode(StatusCodes.Status200OK, ambienteDtoResponse);
        }

        [HttpGet("byName/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AmbienteDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<IEnumerable<AmbienteDtoResponse[]>>> GetAllAmbienteByNameAsync(string name, [FromQuery] bool included = false)
        {
            IEnumerable<Ambiente> ambientes;

            if (included)
            {
                ambientes = await _iAmbienteService.GetAllAmbienteByNameAsync(name);
            }
            else
            {
                ambientes = await _iAmbienteService.GetAllAmbienteByNameAsync(name);
            }

            if (ambientes == null) return NotFound("Não foi possivel bsucar os dados.");

            var ambienteDtoResponse = _mapper.Map<IEnumerable<AmbienteDtoResponse>>(ambientes);

            return this.StatusCode(StatusCodes.Status200OK, ambienteDtoResponse);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AmbienteDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<AmbienteDtoResponse>> GetById(int id)
        {
            var ambiente = await _iAmbienteService.FindByIdAsync(id);

            if (ambiente == null)
            {
                return NotFound("Não foi possivel bsucar os dados.");
            }

            var ambienteDtoResponse = _mapper.Map<AmbienteDtoResponse>(ambiente);

            return this.StatusCode(StatusCodes.Status200OK, ambienteDtoResponse);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Ambiente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Ambiente>> Put(int id, AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);
            var isUpdated = await _iAmbienteService.Update(id, ambiente);
           
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(ambiente);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Ambiente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Ambiente>> Post(AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);

            var isCreated = await _iAmbienteService.Create(ambiente);

            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = ambiente.Id }, ambiente);
        }
    }
}