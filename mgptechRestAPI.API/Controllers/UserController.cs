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
    public class UserController : ControllerBase
    {

        private readonly IUserService _iUserService;
        private readonly IMapper _mapper;

        public UserController(IUserService IuserService, IMapper mapper)
        {
            _mapper = mapper;
            _iUserService = IuserService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var users = await _iUserService.FindAllAsync();

            return Ok(_mapper.Map<IEnumerable<UserDtoResponse>>(users));
        }

       
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _iUserService.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AmbienteDtoResponse>(user));
        }

        
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserDtoRequest userDtoRequest)
        {
            var user = _mapper.Map<User>(userDtoRequest);

            var isCreated = await _iUserService.Create(user);
            if (isCreated)
            {
                return Ok(user);
            }

            return BadRequest("Falha no procedimento");
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UserDtoRequest userDtoRequest)
        {
            var user = _mapper.Map<User>(userDtoRequest);
            var isUpdated = await _iUserService.Update(id, user);
            if (isUpdated)
            {
                return Ok(user);
            }

            return BadRequest("Falha no procedimento");
        }

    
    }
}
