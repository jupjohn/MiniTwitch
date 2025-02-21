using System.Text.Json.Serialization;
using MiniTwitch.Helix.Models;

namespace MiniTwitch.Helix.Responses;

public class ExtensionAnalytics : PaginableResponse<ExtensionAnalytics.Analytics>
{
    public record Analytics(
        [property: JsonPropertyName("extension_id")] string ExtensionId,
        [property: JsonPropertyName("URL")] string Url,
        [property: JsonPropertyName("type")] string Type,
        [property: JsonPropertyName("date_range")] DateRange DateRange
    );
    public record DateRange(
        [property: JsonPropertyName("started_at")] DateTime StartedAt,
        [property: JsonPropertyName("ended_at")] DateTime EndedAt
    );
}