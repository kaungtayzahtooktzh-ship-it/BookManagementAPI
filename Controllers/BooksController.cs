using FirstAPI.Data;
using FirstAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //static private List<Books> books = new List<Books>
        //{
        //    new Books
        //    {
        //        Book_id = 1,
        //        Title = "To Kill a Mockingbird",
        //        Author = "Harper Lee",
        //        Public_year = 1960
        //    },
        //    new Books
        //    {
        //        Book_id = 2,
        //        Title = "1984",
        //        Author = "George Orwell",
        //        Public_year = 1949
        //    },
        //    new Books
        //    {
        //        Book_id=3,
        //        Title = "The Great Gatsby",
        //        Author  = "F. Scott Fitzgerald",
        //        Public_year = 1813
        //    },
        //    new Books
        //    {
        //        Book_id = 4,
        //        Title = "Pride and Prejudice",
        //        Author = "Jane Austen",
        //        Public_year =1813
        //    },
        //    new Books
        //    {
        //        Book_id = 5,
        //        Title = "The Hobbit",
        //        Author = "J.R.R Tolkien",
        //        Public_year = 1937
        //    }
        //};
        private readonly FirstAPIContext _context;
        public BooksController(FirstAPIContext context)
        { //constructor
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Books>>> GetBook()
        {
            return Ok(await _context.Books.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Books>> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Books>> AddBook(Books newbook)
        {
            if (newbook == null)
            {
                return BadRequest();
            }
            _context.Books.Add(newbook);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBookById), new { id = newbook.Book_id }, newbook); //CreatedAtAction has three params 
            //the first param being nameofmethod , 2nd is requirement from that method , 3rd is our new object
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Books updatedbook) //IAction Result doesnt return any thing
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            book.Title = updatedbook.Title;
            book.Author = updatedbook.Author;
            book.Public_year = updatedbook.Public_year;

            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookwithId(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }







    }
}
