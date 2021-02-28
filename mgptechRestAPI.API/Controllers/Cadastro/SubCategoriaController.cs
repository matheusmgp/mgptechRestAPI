using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    [Route("api/subCategorias")]
    [ApiController]
    public class SubCategoriaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISubCategoriaService _iSubCategoriaService;
     

        public SubCategoriaController(IMapper mapper,ISubCategoriaService iSubCategoriaService)
        {
            _mapper = mapper;
            _iSubCategoriaService = iSubCategoriaService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SubCategoriaDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<SubCategoriaDtoResponse>>> GetAll()
        {
            var retorno = await _iSubCategoriaService.FindAllAsync();

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<IEnumerable<SubCategoriaDtoResponse>>(retorno);
            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SubCategoriaDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<SubCategoriaDtoResponse>> GetById(int id)
        {
            var retorno = await _iSubCategoriaService.FindByIdAsync(id);

            if (retorno == null) return NotFound("Não foi possivel bsucar os dados.");

            var dtoResponse = _mapper.Map<SubCategoriaDtoResponse>(retorno);

            return this.StatusCode(StatusCodes.Status200OK, dtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SubCategoria))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<SubCategoria>> Post(SubCategoriaDtoRequest dto)
        {
            var retorno = _mapper.Map<SubCategoria>(dto);  
            var isCreated = await _iSubCategoriaService.Create(retorno);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = retorno.Id }, retorno);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Categoria))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<SubCategoria>> Put(int id, SubCategoriaDtoRequest dto)
        {
            var retorno = _mapper.Map<SubCategoria>(dto);
         
            var isUpdated = await _iSubCategoriaService.Update(id, retorno);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(retorno);
        }
    }
}
