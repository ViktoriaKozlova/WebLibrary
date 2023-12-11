using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;
using WebLibrary.Data;



namespace WebLibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceUserController : ControllerBase
{

    private readonly WebLibraryContext _context;

    public ServiceUserController(WebLibraryContext context)
    {
        _context = context;
    }
    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUser()
    {
        if (_context.Users == null)
        {
            return NotFound();
        }
        return await _context.Users.ToListAsync();
    }
    
     [HttpPost]
            public void Post([FromBody] User value)
            {
                _context.Users.AddRange(value);
                    _context.SaveChanges();
                
            }

            [HttpPut]
            public async Task<ActionResult<User>> Put(User i)
            {
                if (i == null)
                {
                    return BadRequest();
                }

                if (!_context.Users.Any(x => x.Iduser == i.Iduser))
                {
                    return NotFound();
                }

                _context.Update(i);
                await _context.SaveChangesAsync();
                return Ok(i);
            }
}