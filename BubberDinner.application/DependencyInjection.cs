using BabberDinner.application.Services.Authentication;
using BubberDinner.application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}