using AutoMapper.Configuration;
using LibraryAPI.DTOs.BookDTOs;
using LibraryAPI.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService= bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var data = await _bookService.GetAllBooks();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var data = await _bookService.GetBookById(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(BookCreateUpdateDto model)
        {
            var data = await _bookService.CreateBook(model);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var data = await _bookService.DeleteBook(id);
            return Ok(data);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id,BookCreateUpdateDto model)
        {
            var data = await _bookService.UpdateBook(id,model);
            return Ok(data);
        }
    }
}
