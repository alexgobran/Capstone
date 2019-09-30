using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRScapstoneProj;
using PRScapstoneProj.Models;

namespace PRScapstoneProj.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        private readonly CapDBContext _context;

        public UsersController(CapDBContext context) {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUser() {
            return await _context.User.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers(int id) {
            var users = await _context.User.FindAsync(id);

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Users users) {
            if (id != users.Id)
            {
                return BadRequest();
            }

            _context.Entry(users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
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

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users users) {
            _context.User.Add(users);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = users.Id }, users);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> DeleteUsers(int id) {
            var users = await _context.User.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            _context.User.Remove(users);
            await _context.SaveChangesAsync();

            return users;
        }

        //Get: api/Employees/username/password
        [HttpGet("{Username}/{Password}")]
        public async Task<ActionResult<Users>> Login(string Username, string Password) {
            var employee = await _context.User.SingleOrDefaultAsync(e => e.Username.Equals(Username) && e.Password.Equals(Password));

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        private bool UsersExists(int id) {
            return _context.User.Any(u => u.Id == id);

        }
        //ADMIN CAN NOT BE REVIEWER
       //// public bool AdminOrReviewer(bool IsAdmin, bool IsReviewer) {
       //     var admin = IsAdmin == true;
       //     var reviewer = IsReviewer == true;
       //     var user = _context.User.Single(a => a.Boole.Equals(IsAdmin) && a.IsReviewer.Equals(IsReviewer));
 
       //     if (admin == true )
       //     {
       //         reviewer = false;
       //     }
            
       //     return user;
       // }

    }
}
