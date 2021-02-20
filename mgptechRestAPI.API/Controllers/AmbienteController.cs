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
    public class AmbientesController : ControllerBase
    {
        private readonly IAmbienteService _iAmbienteService;
        private readonly IMapper _mapper;

        public AmbientesController(IAmbienteService iAmbienteService, IMapper mapper)
        {
            _mapper = mapper;
            _iAmbienteService = iAmbienteService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ambiente>>> Get()
        {
            var ambientes = await _iAmbienteService.FindAllAsync();

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
        public ActionResult Put(int id, AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);
            _iAmbienteService.Update(id, ambiente);
            if (_iAmbienteService.SaveChanges())
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");
        }

        [HttpPost]
        public ActionResult Post(AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);

            _iAmbienteService.Create(ambiente);
            if (_iAmbienteService.SaveChanges())
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");
        }
    }
}