using System.Diagnostics.CodeAnalysis;

namespace CoffeeRoller.Services.Google;

[ExcludeFromCodeCoverage]
public class GooglePlaceApiService : IGooglePlaceApiService
{
    private readonly HttpClient _httpClient;
    
    public GooglePlaceApiService(HttpClient client)
    {
        _httpClient = client;
    }
    
    public async Task<HttpResponseMessage> GetNearbyPlaces()
    {
        return await _httpClient.GetAsync("nearbysearch/json?")
                                .ConfigureAwait(false);
    }
}