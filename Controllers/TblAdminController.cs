using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblAdminController : ControllerBase
    {
        private readonly LibrarySystemContext _context;

        public TblAdminController(LibrarySystemContext context)
        {
            _context = context;
        }

        // GET: api/TblAdmin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblAdmin>>> GetTblAdmins()
        {
            return await _context.TblAdmins.ToListAsync();
        }

        // GET: api/TblAdmin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblAdmin>> GetTblAdmin(int id)
        {
            var tblAdmin = await _context.TblAdmins.FindAsync(id);

            if (tblAdmin == null)
            {
                return NotFound();
            }

            return tblAdmin;
        }

        // PUT: api/TblAdmin/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblAdmin(int id, TblAdmin tblAdmin)
        {
            if (id != tblAdmin.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(tblAdmin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblAdminExists(id))
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

        // POST: api/TblAdmin
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblAdmin>> PostTblAdmin(TblAdmin tblAdmin)
        {
            _context.TblAdmins.Add(tblAdmin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblAdmin", new { id = tblAdmin.AdminId }, tblAdmin);
        }

        // DELETE: api/TblAdmin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblAdmin(int id)
        {
            var tblAdmin = await _context.TblAdmins.FindAsync(id);
            if (tblAdmin == null)
            {
                return NotFound();
            }

            _context.TblAdmins.Remove(tblAdmin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblAdminExists(int id)
        {
            return _context.TblAdmins.Any(e => e.AdminId == id);
        }
    }
}
