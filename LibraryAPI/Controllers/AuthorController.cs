using LibraryAPI.DTOs.AuthorDTOs;
using LibraryAPI.DTOs.BookDTOs;
using LibraryAPI.Services.Abstractions;
using LibraryAPI.Services.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService= authorService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var data = await _authorService.GetAllAuthors();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var data = await _authorService.GetAuthorById(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthor(AuthorCreateUpdateDto model)
        {
            var data = await _authorService.CreateAuthor(model);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var data = await _authorService.DeleteAuthor(id);
            return Ok(data);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, AuthorCreateUpdateDto model)
        {
            var data = await _authorService.UpdateAuthor(id, model);
            return Ok(data);
        }
    }
}
