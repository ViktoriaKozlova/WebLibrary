
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;
using WebLibrary.Data;



namespace WebLibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceIssuedController : ControllerBase
{

    private readonly WebLibraryContext _context;

    public ServiceIssuedController(WebLibraryContext context)
    {
        _context = context;
    }
    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Issued>>> GetIssued()
    {
        if (_context.Issueds == null)
        {
            return NotFound();
        }
        return await _context.Issueds.ToListAsync();
    }
    
    [HttpPost]
    public void Post([FromBody] Issued value)
    {
        _context.Issueds.AddRange(value);
        _context.SaveChanges();
                
    }

   
    
    
        
    [HttpGet("getActive")]
    public IActionResult GetReservation(int? UserIduser)
    {
        var _Issueds = _context.Issueds.AsQueryable();

      
        if (UserIduser != null)
        {
            _Issueds = _Issueds.Where(a => a.UserIduser == UserIduser);
        }

        var Issueds = _Issueds.ToList();

        if (Issueds.Count == 0)
        {
            return NotFound();
        }

        return Ok(Issueds);
    }
}


