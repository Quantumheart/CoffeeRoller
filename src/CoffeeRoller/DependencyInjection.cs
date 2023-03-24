using CoffeeRoller.Services.Google;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeRoller;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddHttpClient<IGooglePlaceApiService, GooglePlaceApiService>(
            client =>
            {
                client.BaseAddress =
                    new Uri("https://maps.googleapis.com/maps/api/place");
            });
        return services;
    }
}