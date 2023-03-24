using CoffeeRoller.Models.Google;
using Newtonsoft.Json;

namespace CoffeeRoller.Services.Google;

public class GetNearbyPlaces : IGetNearbyPlaces
{
    private readonly IGooglePlaceApiService _googlePlaceApi;
    
    public GetNearbyPlaces(IGooglePlaceApiService googlePlaceApi)
    {
        _googlePlaceApi = googlePlaceApi;
    }
    
    public async Task<PlacesNearbySearchResponse> GetPlacesNearby()
    {
        var apiResponse = await _googlePlaceApi.GetNearbyPlaces();
        if (!apiResponse.IsSuccessStatusCode)
            return new PlacesNearbySearchResponse();
        var content = await apiResponse.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<PlacesNearbySearchResponse>(
            content)!;

    }
}