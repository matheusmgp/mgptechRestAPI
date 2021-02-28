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
    [Route("api/canais")]
    [ApiController]
    public class CanalComunicacaoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICanalComunicacaoService _CanalComunicacaoService;

        public CanalComunicacaoController(IMapper mapper, ICanalComunicacaoService iCanalComunicacaoService)
        {
            _mapper = mapper;
            _CanalComunicacaoService = iCanalComunicacaoService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CanalComunicacaoDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        public async Task<ActionResult<IEnumerable<CanalComunicacaoDtoResponse>>> GetAll()
        {
            var canais = await _CanalComunicacaoService.FindAllAsync();

            if (canais == null) return NotFound("Não foi possivel buscar os dados.");

            var canalDtoResponse = _mapper.Map<IEnumerable<CanalComunicacaoDtoResponse>>(canais);
            return this.StatusCode(StatusCodes.Status200OK, canalDtoResponse);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CanalComunicacaoDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        public async Task<ActionResult<CanalComunicacaoDtoResponse>> GetById(int id)
        {
            var canal = await _CanalComunicacaoService.FindByIdAsync(id);

            if (canal == null) return NotFound("Não foi possivel buscar os dados.");

            var canalDtoResponse = _mapper.Map<CanalComunicacaoDtoResponse>(canal);

            return this.StatusCode(StatusCodes.Status200OK, canalDtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CanalComunicacao))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<CanalComunicacao>> Post(CanalComunicacaoDtoRequest canalComunicacaoDtoRequest)
        {
            var canal = _mapper.Map<CanalComunicacao>(canalComunicacaoDtoRequest);

            var isCreated = await _CanalComunicacaoService.Create(canal);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = canal.Id }, canal);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Role))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<CanalComunicacao>> Put(int id, CanalComunicacaoDtoRequest canalComunicacaoDtoRequest)
        {
            var canal = _mapper.Map<CanalComunicacao>(canalComunicacaoDtoRequest);
            var isUpdated = await _CanalComunicacaoService.Update(id, canal);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(canal);
        }
    }
}