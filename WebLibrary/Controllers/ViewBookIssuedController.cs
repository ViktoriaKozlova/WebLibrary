

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;
using WebLibrary.Data;



namespace WebLibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ViewBookIssuedController: ControllerBase
{

    private readonly WebLibraryContext _context;

    public ViewBookIssuedController(WebLibraryContext context)
    {
        _context = context;
    }
    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ViewBookIssued>>> GetViewBookIssued()
    {
        if (_context.ViewBookIssueds == null)
        {
            return NotFound();
        }
        return await _context.ViewBookIssueds.ToListAsync();
    }
    
    [HttpGet("getActive")]
    public IActionResult GetViewBookIssued(int? countBook, long? countIssuedBook)
    {
        var _ViewBookIssueds = _context.ViewBookIssueds.AsQueryable();

        if (countBook != null)
        {
            _ViewBookIssueds = _ViewBookIssueds.Where(a => a.countBook == countBook);
        }

        if (countIssuedBook != null)
        {
            _ViewBookIssueds = _ViewBookIssueds.Where(a => a.CountIssuedBook == countIssuedBook);
        }

        
        
        var ViewBookIssueds = _ViewBookIssueds.ToList();

        if (ViewBookIssueds.Count == 0)
        {
            return NotFound();
        }

        return Ok(ViewBookIssueds);
    }

   
}