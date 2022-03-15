using System.Text.Json.Serialization;

namespace Hotelsql.DTOs;

public record ScheduleDTO
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("check_in")]
    public DateTimeOffset CheckIn { get; set; }

    [JsonPropertyName("check_out")]
    public DateTimeOffset CheckOut { get; set; }

    [JsonPropertyName("guest_count")]
    public int GuestCount { get; set; }

    [JsonPropertyName("price")]
    public double Price { get; set; }

    [JsonPropertyName("room")]
    public RoomDTO Rooms { get; set; }
     [JsonPropertyName("Guest")]
    public GuestDTO Guest { get; set; }
   
}

public record ScheduleCreateDTO
{

    [JsonPropertyName("check_in")]
    public DateTimeOffset CheckIn { get; set; }

    [JsonPropertyName("check_out")]
    public DateTimeOffset CheckOut { get; set; }

    [JsonPropertyName("guest_count")]
    public int GuestCount { get; set; }

    [JsonPropertyName("price")]
    public double Price { get; set; }
}