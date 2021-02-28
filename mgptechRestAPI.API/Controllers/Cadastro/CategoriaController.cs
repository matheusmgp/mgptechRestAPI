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
    [Route("api/categorias")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaService _iCategoriaService;

        public CategoriaController(IMapper mapper, ICategoriaService iCategoriaService)
        {
            _mapper = mapper;
            _iCategoriaService = iCategoriaService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CategoriaDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<CategoriaDtoResponse>>> GetAll()
        {
            var retorno = await _iCategoriaService.FindAllAsync();

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<IEnumerable<CategoriaDtoResponse>>(retorno);
            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CategoriaDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaDtoResponse>> GetById(int id)
        {
            var retorno = await _iCategoriaService.FindByIdAsync(id);

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<CategoriaDtoResponse>(retorno);

            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Categoria))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Categoria>> Post(CategoriaDtoRequest dto)
        {
            var retorno = _mapper.Map<Categoria>(dto);

            var isCreated = await _iCategoriaService.Create(retorno);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = retorno.Id }, retorno);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Categoria))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Categoria>> Put(int id, CategoriaDtoRequest dto)
        {
            var retorno = _mapper.Map<Categoria>(dto);
            var isUpdated = await _iCategoriaService.Update(id, retorno);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(retorno);
        }
    }
}