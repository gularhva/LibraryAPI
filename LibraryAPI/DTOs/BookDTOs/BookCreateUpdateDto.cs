namespace LibraryAPI.DTOs.BookDTOs;

public class BookCreateUpdateDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public int AuthorId { get; set; }
}