using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Core.Interfaces.Services.Register;
using mgptechRestAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mgptechRestAPI.API.Controllers.Register
{
    [Route("api/account")]
    [ApiController]
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserRegisterService _IuserRegisterService;
        private readonly IMapper _mapper;

        public UserRegisterController(
                                IUserRegisterService userRegisterService,
                                IMapper mapper)
        {
            _IuserRegisterService = userRegisterService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDtoResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [AllowAnonymous]
        public async Task<ActionResult<UserDtoResponse>> Authenticate(UserDtoRequest userDtoRequest)
        {
            try
            {                
                var user = _mapper.Map<User>(userDtoRequest);
                var exists = await _IuserRegisterService.EmailExists(user);

                if (exists) return BadRequest(new { message = "Email ja existe." });

                user.Senha = BCrypt.Net.BCrypt.HashPassword(user.Senha);
                var isRegistered = await _IuserRegisterService.Register(user);

                if (!isRegistered) return BadRequest("Falha no procedimento");

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
