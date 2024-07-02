using AutoMapper;
using LibraryAPI.Contexts;
using LibraryAPI.DTOs.BookDTOs;
using LibraryAPI.Entities;
using LibraryAPI.Models;
using LibraryAPI.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Services.Implementations;

public class BookService : IBookService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public BookService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GenericResponseModel<List<BookGetDto>>> GetAllBooks()
    {
        var response = new GenericResponseModel<List<BookGetDto>>();
        if (_context.Books != null)
        {
            var books = await _context.Books.ToListAsync();
            var result = _mapper.Map<List<BookGetDto>>(books);
            response.Data = result;
        }

        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<BookGetDto>> GetBookById(int id)
    {
        var response = new GenericResponseModel<BookGetDto>();
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        response.Data = _mapper.Map<BookGetDto>(book);
        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<bool>> UpdateBook(int id, BookCreateUpdateDto model)
    {
        var response = new GenericResponseModel<bool>();
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        _mapper.Map(model, book);
        response.Data = true;
        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<bool>> DeleteBook(int id)
    {
        var response = new GenericResponseModel<bool>();
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        _context.Books.Remove(book);
        response.Data = true;
        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<BookCreateUpdateDto>> CreateBook(BookCreateUpdateDto model)
    {
        var response = new GenericResponseModel<BookCreateUpdateDto>();
        var book = _mapper.Map<Book>(model);
        _context.Books.Add(book);
        response.StatusCode = 200;
        response.Data = model;
        return response;
    }
}