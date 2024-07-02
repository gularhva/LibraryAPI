using LibraryAPI.Entities.Common;

namespace LibraryAPI.DTOs.BookDTOs;

public class BookGetDto : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime DateCreated { get; set; }
    public bool IsAvailable { get; set; }
    public int AuthorId { get; set; }
}