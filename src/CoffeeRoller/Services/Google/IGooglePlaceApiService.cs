namespace CoffeeRoller.Services.Google;

public interface IGooglePlaceApiService
{
    Task<HttpResponseMessage> GetNearbyPlaces();
}