#region

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDCS.Data;
using CDCS.Model;
using CDCS.Model.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Cdcs.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class AccreditationsController : ControllerBase {
        private readonly CdcsContext _context;

        public AccreditationsController(CdcsContext context) {
            _context = context;
        }

        // GET: api/Accreditations
        [HttpGet]
        public IEnumerable<Accreditation> GetAccreditations() {
            return _context.Accreditations;
        }

        // GET: api/Accreditations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccreditation([FromRoute] int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var accreditation = await _context.Accreditations.FindAsync(id);

            if (accreditation == null) return NotFound();

            return Ok(accreditation);
        }

        // PUT: api/Accreditations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccreditation([FromRoute] int id, [FromBody] Accreditation accreditation) {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id != accreditation.Id) return BadRequest();

            _context.Entry(accreditation).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!AccreditationExists(id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // POST: api/Accreditations
        [HttpPost]
        public async Task<IActionResult> PostAccreditation([FromBody] Accreditation accreditation) {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _context.Accreditations.Add(accreditation);

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException) {
                if (AccreditationExists(accreditation.Id))
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                throw;
            }

            return CreatedAtAction("GetAccreditation", new { id = accreditation.Id }, accreditation);
        }

        // DELETE: api/Accreditations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccreditation([FromRoute] int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var accreditation = await _context.Accreditations.FindAsync(id);
            if (accreditation == null) return NotFound();

            _context.Accreditations.Remove(accreditation);
            await _context.SaveChangesAsync();

            return Ok(accreditation);
        }

        private bool AccreditationExists(int id) {
            return _context.Accreditations.Any(e => e.Id == id);
        }
    }

}