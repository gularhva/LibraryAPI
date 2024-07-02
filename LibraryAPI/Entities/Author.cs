using LibraryAPI.Entities.Common;

namespace LibraryAPI.Entities;

public class Author : BaseEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDay { get; set; }
    public ICollection<Book>? Books { get; set; }
}