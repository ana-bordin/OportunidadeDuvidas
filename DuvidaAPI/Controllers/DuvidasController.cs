using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DuvidaAPI.Data;
using Models;

namespace DuvidaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuvidasController : ControllerBase
    {
        private readonly DuvidaAPIContext _context;

        public DuvidasController(DuvidaAPIContext context)
        {
            _context = context;
        }

        // GET: api/Duvidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Duvida>>> GetDuvida()
        {
          if (_context.Duvida == null)
          {
              return NotFound();
          }
            return await _context.Duvida.ToListAsync();
        }

        // GET: api/Duvidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Duvida>> GetDuvida(int id)
        {
          if (_context.Duvida == null)
          {
              return NotFound();
          }
            var duvida = await _context.Duvida.FindAsync(id);

            if (duvida == null)
            {
                return NotFound();
            }

            return duvida;
        }

        // PUT: api/Duvidas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDuvida(int id, Duvida duvida)
        {
            if (id != duvida.Id)
            {
                return BadRequest();
            }

            _context.Entry(duvida).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DuvidaExists(id))
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

        // POST: api/Duvidas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Duvida>> PostDuvida(Duvida duvida)
        {
          if (_context.Duvida == null)
          {
              return Problem("Entity set 'DuvidaAPIContext.Duvida'  is null.");
          }
            _context.Duvida.Add(duvida);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDuvida", new { id = duvida.Id }, duvida);
        }

        // DELETE: api/Duvidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDuvida(int id)
        {
            if (_context.Duvida == null)
            {
                return NotFound();
            }
            var duvida = await _context.Duvida.FindAsync(id);
            if (duvida == null)
            {
                return NotFound();
            }

            _context.Duvida.Remove(duvida);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DuvidaExists(int id)
        {
            return (_context.Duvida?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
