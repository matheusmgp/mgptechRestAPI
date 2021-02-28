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
    [Route("api/procedimentos")]
    [ApiController]
    public class ProcedimentoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProcedimentoService _iProcedimentoService;

        public ProcedimentoController(IMapper mapper, IProcedimentoService procedimentoService)
        {
            _mapper = mapper;
            _iProcedimentoService = procedimentoService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProcedimentoDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ProcedimentoDtoResponse>>> GetAll()
        {
            var retorno = await _iProcedimentoService.FindAllAsync();

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<IEnumerable<ProcedimentoDtoResponse>>(retorno);
            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProcedimentoDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProcedimentoDtoResponse>> GetById(int id)
        {
            var retorno = await _iProcedimentoService.FindByIdAsync(id);

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<ProcedimentoDtoResponse>(retorno);

            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Procedimento))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Procedimento>> Post(ProcedimentoDtoRequest dto)
        {
            var retorno = _mapper.Map<Procedimento>(dto);

            var isCreated = await _iProcedimentoService.Create(retorno);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = retorno.Id }, retorno);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Procedimento))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Procedimento>> Put(int id, ProcedimentoDtoRequest dto)
        {
            var retorno = _mapper.Map<Procedimento>(dto);
            var isUpdated = await _iProcedimentoService.Update(id, retorno);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(retorno);
        }
    }
}
