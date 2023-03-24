using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

public class Photo
{
    [JsonProperty("height")] public int Height { get; set; }

    [JsonProperty("html_attributions")]
    public List<string> HtmlAttributions { get; set; }

    [JsonProperty("photo_reference")] public string PhotoReference { get; set; }

    [JsonProperty("width")] public int Width { get; set; }
}