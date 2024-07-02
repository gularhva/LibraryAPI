using LibraryAPI.DTOs.BookDTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Services.Abstractions;

public interface IBookService
{
    public Task<GenericResponseModel<List<BookGetDto>>> GetAllBooks();
    public Task<GenericResponseModel<BookGetDto>> GetBookById(int id);
    public Task<GenericResponseModel<bool>> UpdateBook(int id, BookCreateUpdateDto model);
    public Task<GenericResponseModel<bool>> DeleteBook(int id);
    public Task<GenericResponseModel<BookCreateUpdateDto>> CreateBook(BookCreateUpdateDto model);
}