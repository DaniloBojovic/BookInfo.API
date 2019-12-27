using AutoMapper;
using BookInfo.API.Models;
using Books.Api.Models;
using Books.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Api.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBooksRepository _booksRepository;
        private readonly IMapper _mapper;

        public BooksController(IBooksRepository booksRepository, IMapper mapper)
        {
            _booksRepository = booksRepository 
                ?? throw new ArgumentNullException(nameof(booksRepository));
            _mapper = mapper;
        }

        [HttpGet("api/books")]
        public async Task<IActionResult> GetBooks()
        {
            var bookEntities = await _booksRepository.GetBooksAsync();
            return Ok(bookEntities);
        }

        [HttpGet("api/books/{id}")]
        public async Task<IActionResult> GetBook(Guid id)
        {
            var bookEntity = await _booksRepository.GetBookAsync(id);
            if (bookEntity == null)
            {
                return NotFound();
            }

            return Ok(bookEntity);
        }

        [HttpPost("api/books")]
        public async Task<IActionResult> CreateBook([FromBody] BookForCreation book)
        {
            var bookEntity = _mapper.Map<Entities.Book>(book);
            _booksRepository.AddBook(bookEntity);

            await _booksRepository.SaveChangesAsync();
            await _booksRepository.GetBookAsync(bookEntity.Id);

            return Ok(bookEntity);
        }

        [HttpPut("api/books/{id}")]
        public async Task<IActionResult> UpdateBook(Guid id, [FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            
            var bookFromRepo = await _booksRepository.GetBookAsync(id);
            bookFromRepo.Title = book.Title;
            bookFromRepo.Author = book.Author;
            _booksRepository.UpdateBook(bookFromRepo);
            await _booksRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("api/books/{id}")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            var book = await _booksRepository.GetBookAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _booksRepository.DeleteBook(book);
            await _booksRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
