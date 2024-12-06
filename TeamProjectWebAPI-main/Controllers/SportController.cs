using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamProjectWebAPI.Data;
using TeamProjectWebAPI.Models;

namespace TeamProjectWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class SportController : ControllerBase
    {
        private readonly TeamContext _context;

        public SportController(TeamContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }


        [HttpGet]
        public IActionResult GetAllSports()
        {
            return Ok(_context.Sports.ToArray());
        }

        [HttpGet("{id}")]
        public IActionResult GetSport(int id)
        {
            var sport = _context.Sports.Find(id);
            return Ok(sport);
        }

        [HttpPost]
        public async Task<ActionResult<Sport>> PostSport(Sport sport)
        {
            _context.Sports.Add(sport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSport", new { id = sport.Id }, sport);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSport(int id, Sport sport)
        {
            if (id != sport.Id)
            {
                return BadRequest();
            }

            _context.Entry(sport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (sport == null)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSport(int id)
        {
            var sport = await _context.Sports.FindAsync(id);
            if (sport == null)
            {
                return NotFound();
            }

            _context.Sports.Remove(sport);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
