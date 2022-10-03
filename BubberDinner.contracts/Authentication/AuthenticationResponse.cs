namespace BubberDinner.contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string Firstname,
    string Lastname,
    string Email,
    string Password,
    string Token
);