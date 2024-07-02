using LibraryAPI.Entities.Common;

namespace LibraryAPI.Entities;

public class Booking : BaseEntity
{
    public int CustomerId { get; set; }
    public int BookId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime BookingTime { get; set; }
    public Customer? Customer { get; set; }
    public Book? Book { get; set; }
    public Employee? Employee { get; set; }
}