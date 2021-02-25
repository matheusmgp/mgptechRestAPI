using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.API.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IEnumerable<Ambiente>>> Get([FromQuery] bool included = false)
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
            

            return Ok(_mapper.Map<IEnumerable<AmbienteDtoResponse>>(ambientes));
        }

        [HttpGet("byName/{name}")]
        public async Task<ActionResult<IEnumerable<Ambiente>>> GetAllAmbienteByNameAsync(string name, [FromQuery] bool included = false)
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
           

            return Ok(_mapper.Map<IEnumerable<AmbienteDtoResponse>>(ambientes));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ambiente>> GetById(int id)
        {
            var ambiente = await _iAmbienteService.FindByIdAsync(id);

            if (ambiente == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AmbienteDtoResponse>(ambiente));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);
            var isUpdated = await _iAmbienteService.Update(id, ambiente);
            //var istrue = _iAmbienteService.SaveChanges();
            if (isUpdated)
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");
        }

        [HttpPost]
        public async Task<ActionResult> Post(AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);

            var isCreated =  await _iAmbienteService.Create(ambiente);
            //var istrue = _iAmbienteService.SaveChanges();
            if (isCreated)
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");
        }
    }
}