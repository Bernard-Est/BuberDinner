namespace BubberDinner.application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string Firstname, string Lastname, string Email, string Password);
    AuthenticationResult Login(string Email, string Password);
}