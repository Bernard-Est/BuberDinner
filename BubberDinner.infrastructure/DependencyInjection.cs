using BubberDinner.application.Common.Intefaces.Authentication;
using BubberDinner.application.Common.Services;
using BubberDinner.infrastructure.Authentication;
using BubberDinner.infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services , ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, jwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();


        return services;
    }
}