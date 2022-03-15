namespace Hotelsql.Models;

public enum StaffShift
{
    Day = 1,
    Night = 2,
}

public record Staff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public long Mobile { get; set; }
    public StaffShift Shift { get; set; }




    public StaffDTO asDto => new StaffDTO
    {
        Mobile = Mobile,
        Name = Name,
        DateOfBirth = DateOfBirth,
    };
}