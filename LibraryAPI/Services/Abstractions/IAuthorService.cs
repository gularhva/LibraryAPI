using LibraryAPI.DTOs.AuthorDTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Services.Abstractions;

public interface IAuthorService
{
    public Task<GenericResponseModel<List<AuthorGetDto>>> GetAllAuthors();
    public Task<GenericResponseModel<AuthorGetDto>> GetAuthorById(int id);
    public Task<GenericResponseModel<bool>> UpdateAuthor(int id, AuthorCreateUpdateDto model);
    public Task<GenericResponseModel<bool>> DeleteAuthor(int id);
    public Task<GenericResponseModel<AuthorCreateUpdateDto>> CreateAuthor(AuthorCreateUpdateDto model);
}