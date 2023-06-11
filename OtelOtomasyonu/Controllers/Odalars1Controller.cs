using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtelOtomasyonu.Data;
using OtelOtomasyonu.Models;

namespace OtelOtomasyonu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Odalars1Controller : ControllerBase
    {
        private readonly MyContext _context;

        public Odalars1Controller(MyContext context)
        {
            _context = context;
        }

        // GET: api/Odalars1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Odalar>>> GetOdalars()
        {
          if (_context.Odalars == null)
          {
              return NotFound();
          }
            return await _context.Odalars.ToListAsync();
        }

        // GET: api/Odalars1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Odalar>> GetOdalar(int id)
        {
          if (_context.Odalars == null)
          {
              return NotFound();
          }
            var odalar = await _context.Odalars.FindAsync(id);

            if (odalar == null)
            {
                return NotFound();
            }

            return odalar;
        }

        // PUT: api/Odalars1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOdalar(int id, Odalar odalar)
        {
            if (id != odalar.OdaId)
            {
                return BadRequest();
            }

            _context.Entry(odalar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OdalarExists(id))
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

        // POST: api/Odalars1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Odalar>> PostOdalar(Odalar odalar)
        {
          if (_context.Odalars == null)
          {
              return Problem("Entity set 'MyContext.Odalars'  is null.");
          }
            _context.Odalars.Add(odalar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOdalar", new { id = odalar.OdaId }, odalar);
        }

        // DELETE: api/Odalars1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOdalar(int id)
        {
            if (_context.Odalars == null)
            {
                return NotFound();
            }
            var odalar = await _context.Odalars.FindAsync(id);
            if (odalar == null)
            {
                return NotFound();
            }

            _context.Odalars.Remove(odalar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OdalarExists(int id)
        {
            return (_context.Odalars?.Any(e => e.OdaId == id)).GetValueOrDefault();
        }
    }
}
