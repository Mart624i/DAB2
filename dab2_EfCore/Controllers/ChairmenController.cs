#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dab2_EfCore.Data;
using dab2_EfCore.Models;

namespace dab2_EfCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChairmenController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ChairmenController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Chairmen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chairman>>> GetChairmen()
        {
            return await _context.Chairmen.ToListAsync();
        }

        // GET: api/Chairmen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chairman>> GetChairman(int id)
        {
            var chairman = await _context.Chairmen.FindAsync(id);

            if (chairman == null)
            {
                return NotFound();
            }

            return chairman;
        }

        // PUT: api/Chairmen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChairman(int id, Chairman chairman)
        {
            if (id != chairman.Member_id)
            {
                return BadRequest();
            }

            _context.Entry(chairman).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChairmanExists(id))
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

        // POST: api/Chairmen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Chairman>> PostChairman(Chairman chairman)
        {
            _context.Chairmen.Add(chairman);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChairman", new { id = chairman.Member_id }, chairman);
        }

        // DELETE: api/Chairmen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChairman(int id)
        {
            var chairman = await _context.Chairmen.FindAsync(id);
            if (chairman == null)
            {
                return NotFound();
            }

            _context.Chairmen.Remove(chairman);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChairmanExists(int id)
        {
            return _context.Chairmen.Any(e => e.Member_id == id);
        }
    }
}
