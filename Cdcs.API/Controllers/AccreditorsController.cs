#region

using System.Collections.Generic;
using System.Threading.Tasks;
using CDCS.Data.QueryObjects;
using CDCS.Data.Services.Interfaces;
using CDCS.Model.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Cdcs.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class AccreditorsController : ControllerBase {
        private readonly IAccreditorService _srv;

        public AccreditorsController(IAccreditorService srv)
        {
            _srv = srv;
        }

        // GET: api/Accreditors
        [HttpGet]
        public IEnumerable<Accreditor> GetAccreditors()
        {
            return _srv.GetAll();
        }

        // GET: api/Accreditors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccreditor([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            // var accreditor = await _context.Accreditors.FindAsync(id);
            var accreditor = await _srv.GetAll().GetAccreditorDtoByIdAsync(id);

            if (accreditor == null) return NotFound();

            return Ok(accreditor);
        }

        // GET: api/Accreditors/5/Accreditations
        [HttpGet("{id}/Accreditations")]
        public async Task<IActionResult> GetAccreditorAccreditations([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var accreditor = await _srv.GetAll().Include(x => x.Accreditations).FirstAsync();

            if (accreditor == null) return NotFound();

            return Ok(accreditor);
        }

        /*
        // PUT: api/Accreditors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccreditor([FromRoute] int id, [FromBody] Accreditor accreditor)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id != accreditor.Id) return BadRequest();

            _srv.Update(accreditor);
            // _context.Entry(accreditor).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!AccreditorExists(id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // POST: api/Accreditors
        [HttpPost]
        public async Task<IActionResult> PostAccreditor([FromBody] Accreditor accreditor)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _context.Accreditors.Add(accreditor);

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException) {
                if (AccreditorExists(accreditor.Id))
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                throw;
            }

            return CreatedAtAction("GetAccreditor", new {id = accreditor.Id}, accreditor);
        }

        // DELETE: api/Accreditors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccreditor([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var accreditor = await _context.Accreditors.FindAsync(id);
            if (accreditor == null) return NotFound();

            _context.Accreditors.Remove(accreditor);
            await _context.SaveChangesAsync();

            return Ok(accreditor);
        }

        private bool AccreditorExists(int id)
        {
            return _context.Accreditors.Any(e => e.Id == id);
        }
    */
    }

}