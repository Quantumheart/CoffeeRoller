using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

public class PlusCode
{
    [JsonProperty("compound_code")] public string CompoundCode { get; set; }

    [JsonProperty("global_code")] public string GlobalCode { get; set; }
}