using System.Text.Json.Serialization;
using MiniTwitch.Helix.Models;

namespace MiniTwitch.Helix.Responses;

public class HypeTrainEvents : PaginableResponse<HypeTrainEvents.Event>
{
    public record Event(
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("event_type")] string EventType,
        [property: JsonPropertyName("event_timestamp")] DateTime EventTimestamp,
        [property: JsonPropertyName("version")] string Version,
        [property: JsonPropertyName("event_data")] EventData EventData
    );

    public record EventData(
        [property: JsonPropertyName("broadcaster_id")] long BroadcasterId,
        [property: JsonPropertyName("cooldown_end_time")] string CooldownEndTime,
        [property: JsonPropertyName("expires_at")] DateTime ExpiresAt,
        [property: JsonPropertyName("goal")] int Goal,
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("last_contribution")] Contribution LastContribution,
        [property: JsonPropertyName("level")] int Level,
        [property: JsonPropertyName("started_at")] string StartedAt,
        [property: JsonPropertyName("top_contributions")] IReadOnlyList<Contribution> TopContributions,
        [property: JsonPropertyName("total")] int Total
    );

    public record Contribution(
        [property: JsonPropertyName("total")] int Total,
        [property: JsonPropertyName("type")] string Type,
        [property: JsonPropertyName("user")] long UserId
    );

}