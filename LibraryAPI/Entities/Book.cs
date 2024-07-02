using LibraryAPI.Entities.Common;

namespace LibraryAPI.Entities;

public class Book : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime DateCreated { get; set; }= DateTime.UtcNow;
    public bool IsAvailable { get; set; }
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}