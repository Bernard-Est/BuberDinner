using BubberDinner.application.Common.Intefaces.Authentication;
using BubberDinner.application.Services.Authentication;

namespace BabberDinner.application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string Email, string Password)
    {
        return new AuthenticationResult (
            Guid.NewGuid(),
            "FirstName",
            "LastName",
            Email,
            Password,
            "token"
        );
    }

    public AuthenticationResult Register(string Firstname, string Lastname, string Email, string Password)
    {
        Guid userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateToken(userId, Firstname, Lastname);

        return new AuthenticationResult (
        userId,
        Firstname,
        Lastname,
        Email,
        Password,
        token
        );
    }
}