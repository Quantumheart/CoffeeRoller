using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

public class Viewport
{
    [JsonProperty("northeast")] public Northeast Northeast { get; set; }

    [JsonProperty("southwest")] public Southwest Southwest { get; set; }
}