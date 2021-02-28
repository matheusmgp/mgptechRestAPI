using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mgptechRestAPI.API.Controllers.Cadastro
{
    [Route("api/setores")]
    [ApiController]
    public class SetorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISetorService _setorService;
        public SetorController(IMapper mapper, ISetorService setorService)
        {
            _mapper = mapper;
            _setorService = setorService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SetorDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<SetorDtoResponse>>> GetAll()
        {
            var retorno = await _setorService.FindAllAsync();

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<IEnumerable<SetorDtoResponse>>(retorno);
            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SetorDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<SetorDtoResponse>> GetById(int id)
        {
            var retorno = await _setorService.FindByIdAsync(id);

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<SetorDtoResponse>(retorno);

            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Setor))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Setor>> Post(SetorDtoRequest dto)
        {
            var retorno = _mapper.Map<Setor>(dto);

            var isCreated = await _setorService.Create(retorno);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = retorno.Id }, retorno);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Setor))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Setor>> Put(int id, SetorDtoRequest dto)
        {
            var retorno = _mapper.Map<Setor>(dto);
            var isUpdated = await _setorService.Update(id, retorno);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(retorno);
        }
    }
}
