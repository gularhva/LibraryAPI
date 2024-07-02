using LibraryAPI.Entities.Common;

namespace LibraryAPI.DTOs.AuthorDTOs;

public class AuthorGetDto : BaseEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDay { get; set; }
}