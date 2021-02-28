using AutoMapper;
using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace mgptechRestAPI.API.Controllers.Auth
{
    [Route("api/account")]
    [ApiController]
    public class UserAuthController : ControllerBase
    {
        private readonly IUserAuthService _IuserAuthService;
        private readonly IRoleService _IroleService;
        private readonly IMapper _mapper;

        public UserAuthController(
                                IUserAuthService userAuthService,
                                IRoleService roleService,
                                IMapper mapper)
        {
            _IuserAuthService = userAuthService;
            _mapper = mapper;
            _IroleService = roleService;
        }

        [HttpPost("login")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserAuthDtoResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [AllowAnonymous]
        public async Task<ActionResult<UserAuthDtoResponse>> Authenticate(UserAuthDtoRequest userAuthDtoRequest)
        {
            try
            {
                var user = _IuserAuthService.Authenticate(userAuthDtoRequest);
                if (user == null)
                    return BadRequest(new { message = "Usuário ou senha inválidos" });

                var userAuthDtoResponse = _mapper.Map<UserAuthDtoResponse>(user);

                var role = await _IroleService.FindByIdAsync(user.RoleId);
                
                userAuthDtoResponse.Role = role.Nome.Trim();

                var token = _IuserAuthService.GenerateTokem(userAuthDtoResponse);

                userAuthDtoResponse.Senha = "";
                userAuthDtoResponse.Token = token;

                return Ok(userAuthDtoResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}