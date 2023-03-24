using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

public class OpeningHours
{
    [JsonProperty("open_now")] public bool OpenNow { get; set; }
}