using AutoMapper;
using LibraryAPI.Contexts;
using LibraryAPI.DTOs.AuthorDTOs;
using LibraryAPI.Entities;
using LibraryAPI.Models;
using LibraryAPI.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Services.Implementations;

public class AuthorService : IAuthorService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public AuthorService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GenericResponseModel<List<AuthorGetDto>>> GetAllAuthors()
    {
        var response = new GenericResponseModel<List<AuthorGetDto>>();
        if (_context.Authors != null)
        {
            var books = await _context.Authors.ToListAsync();
            var result = _mapper.Map<List<AuthorGetDto>>(books);
            response.Data = result;
        }

        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<AuthorGetDto>> GetAuthorById(int id)
    {
        var response = new GenericResponseModel<AuthorGetDto>();
        var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        response.Data = _mapper.Map<AuthorGetDto>(author);
        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<bool>> UpdateAuthor(int id, AuthorCreateUpdateDto model)
    {
        var response = new GenericResponseModel<bool>();
        var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        _mapper.Map(model, author);
        response.Data = true;
        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<bool>> DeleteAuthor(int id)
    {
        var response = new GenericResponseModel<bool>();
        var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        _context.Authors.Remove(author);
        response.Data = true;
        response.StatusCode = 200;
        return response;
    }

    public async Task<GenericResponseModel<AuthorCreateUpdateDto>> CreateAuthor(AuthorCreateUpdateDto model)
    {
        var response = new GenericResponseModel<AuthorCreateUpdateDto>();
        var author = _mapper.Map<Author>(model);
        _context.Authors.Add(author);
        response.StatusCode = 200;
        response.Data = model;
        return response;
    }
}