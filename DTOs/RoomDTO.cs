using System.Text.Json.Serialization;

namespace Hotelsql.DTOs;

public record RoomDTO
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("staff_name")]
    public string StaffName { get; set; }
     [JsonPropertyName("staff")]
    public List<StaffDTO> staff { get; set; }
}

public record RoomCreateDTO
{
   

    [JsonPropertyName("type")]
    public string Type { get; set; }
    
   [JsonPropertyName("staff_name")]
    public string StaffName { get; set; }
}