using AutoMapper;
using LibraryAPI.DTOs.AuthorDTOs;
using LibraryAPI.DTOs.BookDTOs;
using LibraryAPI.Entities;

namespace LibraryAPI.Profiles;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Book, BookGetDto>().ReverseMap();
        CreateMap<Book, BookCreateUpdateDto>().ReverseMap();
        CreateMap<Author, AuthorCreateUpdateDto>().ReverseMap();
        CreateMap<Author, AuthorGetDto>().ReverseMap();
    }
}