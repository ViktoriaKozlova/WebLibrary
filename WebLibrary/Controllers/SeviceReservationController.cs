
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;
using WebLibrary.Data;



namespace WebLibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SeviceReservationController: ControllerBase
{

    private readonly WebLibraryContext _context;

    public SeviceReservationController(WebLibraryContext context)
    {
        _context = context;
    }
    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Reservation>>> GetReservation()
    {
        if (_context.Reservations == null)
        {
            return NotFound();
        }
        return await _context.Reservations.ToListAsync();
    }
  
    
    
    [HttpGet("getActive")]
    public IActionResult GetReservation(int? UserIduser)
    {
        var _Reservations = _context.Reservations.AsQueryable();

      
        if (UserIduser != null)
        {
            _Reservations = _Reservations.Where(a => a.UserIduser == UserIduser);
        }

        var Reservations = _Reservations.ToList();

        if (Reservations.Count == 0)
        {
            return NotFound();
        }

        return Ok(Reservations);
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    [HttpPost]
    public void Post([FromBody] Reservation value)
    {
        _context.Reservations.AddRange(value);
        _context.SaveChanges();
                
    }

   
}