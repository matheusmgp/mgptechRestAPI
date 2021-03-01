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

namespace mgptechRestAPI.API.Controllers.Cadastro
{
    [Route("api/filiais")]
    [ApiController]
    public class FilialController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFilialService _iFilialService;

        public FilialController(IMapper mapper, IFilialService iFilialService)
        {
            _mapper = mapper;
            _iFilialService = iFilialService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FilialDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<FilialDtoResponse>>> GetAll()
        {
            var retorno = await _iFilialService.FindAllAsync();

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<IEnumerable<FilialDtoResponse>>(retorno);
            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FilialDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FilialDtoResponse>> GetById(int id)
        {
            var retorno = await _iFilialService.FindByIdAsync(id);

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<FilialDtoResponse>(retorno);

            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Filial))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Filial>> Post(FilialDtoRequest dto)
        {
            var retorno = _mapper.Map<Filial>(dto);

            var isCreated = await _iFilialService.Create(retorno);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = retorno.Id }, retorno);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Filial))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Filial>> Put(int id, FilialDtoRequest dto)
        {
            var retorno = _mapper.Map<Filial>(dto);
            var isUpdated = await _iFilialService.Update(id, retorno);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(retorno);
        }
    }
}