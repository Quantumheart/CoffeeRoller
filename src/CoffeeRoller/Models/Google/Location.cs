using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

public class Location
{
    [JsonProperty("lat")] public double Lat { get; set; }

    [JsonProperty("lng")] public double Lng { get; set; }
}