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
    public class RequestsController : ControllerBase
    {
        private readonly CapDBContext _context;

        public RequestsController(CapDBContext context)
        {
            _context = context;
        }

        // GET: api/Requests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Requests>>> GetRequest()
        {
            return await _context.Request.ToListAsync();
        }

        // GET: api/Requests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Requests>> GetRequests(int id)
        {
            var requests = await _context.Request.FindAsync(id);

            if (requests == null)
            {
                return NotFound();
            }

            return requests;
        }

        // PUT: api/Requests/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequests(int id, Requests requests)
        {
            if (id != requests.Id)
            {
                return BadRequest();
            }

            _context.Entry(requests).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestsExists(id))
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

        // POST: api/Requests
        [HttpPost]
        public async Task<ActionResult<Requests>> PostRequests(Requests requests)
        {
            _context.Request.Add(requests);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequests", new { id = requests.Id }, requests);
        }

        // DELETE: api/Requests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Requests>> DeleteRequests(int id)
        {
            var requests = await _context.Request.FindAsync(id);
            if (requests == null)
            {
                return NotFound();
            }

            _context.Request.Remove(requests);
            await _context.SaveChangesAsync();

            return requests;
        }

        private bool RequestsExists(int id)
        {
            return _context.Request.Any(e => e.Id == id);
        }
    }
}
