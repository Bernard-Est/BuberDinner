using BubberDinner.application.Services.Authentication;
using BubberDinner.contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BubberDinner.api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authenticationService.Register(request.Firstname, request.Lastname, request.Email, request.Password);

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.Firstname,
            authResult.Lastname,
            authResult.Email,
            authResult.Password,
            authResult.Token
        );

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request){
                var authResult = _authenticationService.Login(request.Email, request.password);

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.Firstname,
            authResult.Lastname,
            authResult.Email,
            authResult.Password,
            authResult.Token
        );

        return Ok(response);
    }
}