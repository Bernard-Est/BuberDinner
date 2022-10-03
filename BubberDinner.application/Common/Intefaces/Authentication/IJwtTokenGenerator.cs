namespace BubberDinner.application.Common.Intefaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(Guid userId, string firstName, string lastName);
}