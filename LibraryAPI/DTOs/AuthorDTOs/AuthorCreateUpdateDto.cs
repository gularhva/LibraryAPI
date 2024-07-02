namespace LibraryAPI.DTOs.AuthorDTOs;

public class AuthorCreateUpdateDto
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDay { get; set; }
}