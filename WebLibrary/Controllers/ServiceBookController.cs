using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;
using WebLibrary.Data;

namespace WebLibrary.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceBookController : ControllerBase
{

    private readonly WebLibraryContext _context;

    public ServiceBookController(WebLibraryContext context)
    {
        _context = context;
    }


    // GET: api/User
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBook()
    {
        if (_context.Books == null)
        {
            return NotFound();
        }

        return await _context.Books.ToListAsync();
    }

    [HttpGet("getActive")]
    public IActionResult GetBook(int? Count, string? Language)
    {
        var _Book = _context.Books.AsQueryable();

        if (Count != null)
        {
            _Book = _Book.Where(a => a.Count == Count);
        }

        if (Language != null)
        {
            _Book = _Book.Where(a => a.Language == Language);
        }

        var Books = _Book.ToList();

        if (Books.Count == 0)
        {
            return NotFound();
        }

        return Ok(Books);
    }


 

    
    
    
    [HttpPost]
    public void Post([FromBody] Book value)
    {
        _context.Books.AddRange(value);
        _context.SaveChanges();

    }

    [HttpPut]
    public async Task<ActionResult<Book>> Put(Book i)
    {
        if (i == null)
        {
            return BadRequest();
        }

        if (!_context.Books.Any(x => x.Idbook == i.Idbook))
        {
            return NotFound();
        }

        _context.Update(i);
        await _context.SaveChangesAsync();
        return Ok(i);
    }
}






