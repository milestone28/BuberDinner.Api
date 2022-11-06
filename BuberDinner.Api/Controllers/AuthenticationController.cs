using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
     
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest req)
        {
            var authResult = _authenticationService.Register(
                req.FirstName,
                req.LastName,
                req.Email,
                req.Password
                );
            var res = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token,
                authResult.Result
                );

            return Ok(res);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest req)
        {
            var authResult = _authenticationService.Login(
              req.Email,
              req.Password
              );
            var res = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token,
                authResult.Result
                );
            return Ok(res);
        }
    }
}
