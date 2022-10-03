namespace BubberDinner.contracts.Authentication;

public record LoginRequest(
    string Email,
    string password
);