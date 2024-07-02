using LibraryAPI.Entities.Common;

namespace LibraryAPI.Entities;

public class Employee : BaseEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDay { get; set; }

    public ICollection<Booking>? Bookings { get; set; }
}