using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

public class Geometry
{
    [JsonProperty("location")] public Location Location { get; set; }

    [JsonProperty("viewport")] public Viewport Viewport { get; set; }
}