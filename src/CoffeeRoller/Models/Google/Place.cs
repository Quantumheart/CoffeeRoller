using Newtonsoft.Json;

namespace CoffeeRoller.Models.Google;

public class Place
{
    [JsonProperty("business_status")] public string BusinessStatus { get; set; }

    [JsonProperty("geometry")] public Geometry Geometry { get; set; }

    [JsonProperty("icon")] public string Icon { get; set; }

    [JsonProperty("icon_background_color")]
    public string IconBackgroundColor { get; set; }

    [JsonProperty("icon_mask_base_uri")]
    public string IconMaskBaseUri { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("opening_hours")]
    public OpeningHours OpeningHours { get; set; }

    [JsonProperty("photos")] public List<Photo> Photos { get; set; }

    [JsonProperty("place_id")] public string PlaceId { get; set; }

    [JsonProperty("plus_code")] public PlusCode PlusCode { get; set; }

    [JsonProperty("price_level")] public int PriceLevel { get; set; }

    [JsonProperty("rating")] public double Rating { get; set; }

    [JsonProperty("reference")] public string Reference { get; set; }

    [JsonProperty("scope")] public string Scope { get; set; }

    [JsonProperty("types")] public List<string> Types { get; set; }

    [JsonProperty("user_ratings_total")]
    public int UserRatingsTotal { get; set; }

    [JsonProperty("vicinity")] public string Vicinity { get; set; }
}