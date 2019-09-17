using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRScapstoneProj;
using PRScapstoneProj.Models;

namespace PRScapstoneProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestLinesController : ControllerBase
    {
        private readonly CapDBContext _context;
        
        public void RecalculateRequestTotal(int requestId) {

             
            var request = RequestsController.(requestId);
            request.Total = request.RequestLine.Sum(l => l.Product.Price * l.Quantity);


             }
        
       

        public RequestLinesController(CapDBContext context)
        {
            _context = context;
        }

        // GET: api/RequestLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequestLines>>> GetRequestLine()
        {
            return await _context.RequestLine.ToListAsync();
        }

        // GET: api/RequestLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RequestLines>> GetRequestLines(int id)
        {
            var requestLines = await _context.RequestLine.FindAsync(id);

            if (requestLines == null)
            {
                return NotFound();
            }

            return requestLines;
        }

        // PUT: api/RequestLines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequestLines(int id, RequestLines requestLines)
        {
            if (id != requestLines.Id)
            {
                return BadRequest();
            }

            _context.Entry(requestLines).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestLinesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RequestLines
        [HttpPost]
        public async Task<ActionResult<RequestLines>> PostRequestLines(RequestLines requestLines)
        {
            _context.RequestLine.Add(requestLines);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequestLines", new { id = requestLines.Id }, requestLines);
        }

        // DELETE: api/RequestLines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RequestLines>> DeleteRequestLines(int id)
        {
            var requestLines = await _context.RequestLine.FindAsync(id);
            if (requestLines == null)
            {
                return NotFound();
            }

            _context.RequestLine.Remove(requestLines);
            await _context.SaveChangesAsync();

            return requestLines;
        }

        private bool RequestLinesExists(int id)
        {
            return _context.RequestLine.Any(e => e.Id == id);
        }
    }
}
