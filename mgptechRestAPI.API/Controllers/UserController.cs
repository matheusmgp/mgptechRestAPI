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

namespace mgptechRestAPI.API.Controllers
{
    [Route("api/users")]
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
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDtoResponse[]))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<UserDtoResponse>>> GetAll()
        {
            var users = await _iUserService.FindAllAsync();

            if (users == null) return NotFound("Não foi possivel bsucar os dados.");

            var userDtoResponse = _mapper.Map<IEnumerable<UserDtoResponse>>(users);

            return this.StatusCode(StatusCodes.Status200OK, userDtoResponse);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDtoResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "All")]
        public async Task<ActionResult<UserDtoResponse>> GetById(int id)
        {
            var user = await _iUserService.FindByIdAsync(id);

            if (user == null) return NotFound("Não foi possivel bsucar os dados.");

            var userDtoResponse = _mapper.Map<UserDtoResponse>(user);

            return this.StatusCode(StatusCodes.Status200OK, userDtoResponse);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<User>> Post([FromBody] UserDtoRequest userDtoRequest)
        {
            var user = _mapper.Map<User>(userDtoRequest);

            var isCreated = await _iUserService.Create(user);
            if (isCreated)
            {
                return Ok(user);
            }

            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);


        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Policy = "Administrador")]
        public async Task<ActionResult<User>> Put(int id, [FromBody] UserDtoRequest userDtoRequest)
        {
            var userFound = await _iUserService.FindByIdAsync(id);
            userDtoRequest.DataCadastro = userFound.DataCadastro;

            var user = _mapper.Map<User>(userDtoRequest);

            var isUpdated = await _iUserService.Update(id, user);
            if (!isUpdated) return BadRequest("Falha no procedimento");

            return Ok(user);
        }
    }
}