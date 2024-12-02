using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamProjectWebAPI.Data;
using TeamProjectWebAPI.Models;

namespace TeamProjectWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class HobbyController : ControllerBase
    {
        private readonly TeamContext _context;

        public HobbyController(TeamContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IActionResult GetAllHobbies()
        {
            return Ok(_context.Hobbies.ToArray());
        }

        [HttpGet("{id}")]
        public IActionResult GetHobby(int id)
        {
            var hobby = _context.Hobbies.Find(id);
            return Ok(hobby);
        }

        [HttpPost]
        public async Task<ActionResult<Hobby>> PostHobby(Hobby hobby)
        {
            _context.Hobbies.Add(hobby);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHobby", new { id = hobby.Id }, hobby);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHobby(int id, Hobby hobby)
        {
            if (id != hobby.Id)
            {
                return BadRequest();
            }

            _context.Entry(hobby).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (hobby == null)
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
        public async Task<IActionResult> DeleteHobby(int id)
        {
            var hobby = await _context.Hobbies.FindAsync(id);
            if (hobby == null)
            {
                return NotFound();
            }

            _context.Hobbies.Remove(hobby);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
