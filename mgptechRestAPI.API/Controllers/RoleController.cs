using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mgptechRestAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<ActionResult<IEnumerable<Role>>> Get()
        {
            var roles = await _iRoleService.FindAllAsync();

            return Ok(_mapper.Map<IEnumerable<RoleDtoResponse>>(roles));
        }


        public async Task<ActionResult<User>> Get(int id)
        {
            var role = await _iRoleService.FindByIdAsync(id);

            if (role == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<RoleDtoResponse>(role));
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RoleDtoRequest roleDtoRequest)
        {
            var role = _mapper.Map<Role>(roleDtoRequest);

            var isCreated = await _iRoleService.Create(role);
            if (isCreated)
            {
                return Ok(role);
            }

            return BadRequest("Falha no procedimento");
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] RoleDtoRequest roleDtoRequest)
        {
            var role = _mapper.Map<Role>(roleDtoRequest);
            var isUpdated = await _iRoleService.Update(id, role);
            if (isUpdated)
            {
                return Ok(role);
            }

            return BadRequest("Falha no procedimento");
        }
    }
}
