using CoffeeRoller.Models.Google;

namespace CoffeeRoller.Services.Google;

public interface IGetNearbyPlaces
{
   Task<PlacesNearbySearchResponse> GetPlacesNearby();
}