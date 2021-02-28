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
    [Route("api/roles")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _iRoleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService iRoleService, IMapper mapper)
        {
            _mapper = mapper;
            _iRoleService = iRoleService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RoleDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        public async Task<ActionResult<IEnumerable<RoleDtoResponse[]>>> GetAll()
        {
            var roles = await _iRoleService.FindAllAsync();

            if (roles == null) return NotFound("Não foi possivel bsucar os dados.");

            var roleDtoResponse = _mapper.Map<IEnumerable<RoleDtoResponse>>(roles);

            return this.StatusCode(StatusCodes.Status200OK, roleDtoResponse);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RoleDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        public async Task<ActionResult<Role>> GetById(int id)
        {
            var role = await _iRoleService.FindByIdAsync(id);

            if (role == null) return NotFound("Não foi possivel bsucar os dados.");

            var roleDtoResponse = _mapper.Map<RoleDtoResponse>(role);

            return this.StatusCode(StatusCodes.Status200OK, roleDtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Role))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Role>> Post([FromBody] RoleDtoRequest roleDtoRequest)
        {
            var role = _mapper.Map<Role>(roleDtoRequest);

            var isCreated = await _iRoleService.Create(role);
            if (!isCreated) return BadRequest("Falha no procedimento");

            return CreatedAtAction(nameof(GetById), new { id = role.Id }, role);
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Role))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<Role>> Put(int id, [FromBody] RoleDtoRequest roleDtoRequest)
        {
            var role = _mapper.Map<Role>(roleDtoRequest);
            var isUpdated = await _iRoleService.Update(id, role);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(role);
        }
    }
}