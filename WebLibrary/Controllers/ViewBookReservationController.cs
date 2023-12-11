
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;
using WebLibrary.Data;



namespace WebLibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ViewBookReservationController: ControllerBase
{

    private readonly WebLibraryContext _context;

    public ViewBookReservationController(WebLibraryContext context)
    {
        _context = context;
    }
    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ViewBookReservation>>> GetViewBookReservation()
    {
        if (_context.ViewBookReservations == null)
        {
            return NotFound();
        }
        return await _context.ViewBookReservations.ToListAsync();
    }
    
    [HttpGet("getActive")]
    public IActionResult GetViewBookReservations(int? countBook, long? countReservationBook)
    {
        var _ViewBookReservations = _context.ViewBookReservations.AsQueryable();

        if (countBook != null)
        {
            _ViewBookReservations = _ViewBookReservations.Where(a => a.countBook == countBook);
        }

        if (countReservationBook != null)
        {
            _ViewBookReservations = _ViewBookReservations.Where(a => a.CountReservationBook == countReservationBook);
        }

        
        
        var ViewBookReservations = _ViewBookReservations.ToList();

        if (ViewBookReservations.Count == 0)
        {
            return NotFound();
        }

        return Ok(ViewBookReservations);
    }

   
}