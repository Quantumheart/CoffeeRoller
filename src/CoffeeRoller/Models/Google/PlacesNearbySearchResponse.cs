using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

/// <summary>
/// Google response model for nearby search requests
/// </summary>
public class PlacesNearbySearchResponse
{
    
    [JsonProperty("html_attributions")]
    public List<string> HtmlAttributions { get; set; }

    [JsonProperty("results")] public List<Place> Results { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("error_message")] public string ErrorMessage { get; set; }

    [JsonProperty("info_messages")]
    public List<string> InfoMesages { get; set; }

    [JsonProperty("next_page_token")] public string NextPageToken { get; set; }
}