using System.Text.Json.Serialization;
using MiniTwitch.Helix.Models;

namespace MiniTwitch.Helix.Responses;

public class UsersChatColor : BaseResponse<UsersChatColor.ColorInfo>
{
    public record ColorInfo(
        [property: JsonPropertyName("user_id")] long Id,
        [property: JsonPropertyName("user_name")] string DisplayName,
        [property: JsonPropertyName("user_login")] string Name,
        [property: JsonPropertyName("color")] string Color
    );
}