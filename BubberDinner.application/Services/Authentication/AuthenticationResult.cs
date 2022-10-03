namespace BubberDinner.application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string Firstname,
    string Lastname,
    string Email,
    string Password,
    string Token
);