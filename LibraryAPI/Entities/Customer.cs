using LibraryAPI.Entities.Common;

namespace LibraryAPI.Entities;

public class Customer : BaseEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDay { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }

    public ICollection<Booking>? Bookings { get; set; }
}