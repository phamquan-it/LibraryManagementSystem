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
    public class TblTransactionController : ControllerBase
    {
        private readonly LibrarySystemContext _context;

        public TblTransactionController(LibrarySystemContext context)
        {
            _context = context;
        }

        // GET: api/TblTransaction
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblTransaction>>> GetTblTransactions()
        {
            return await _context.TblTransactions.ToListAsync();
        }

        // GET: api/TblTransaction/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblTransaction>> GetTblTransaction(int id)
        {
            var tblTransaction = await _context.TblTransactions.FindAsync(id);

            if (tblTransaction == null)
            {
                return NotFound();
            }

            return tblTransaction;
        }

        // PUT: api/TblTransaction/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblTransaction(int id, TblTransaction tblTransaction)
        {
            if (id != tblTransaction.TranId)
            {
                return BadRequest();
            }

            _context.Entry(tblTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblTransactionExists(id))
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

        // POST: api/TblTransaction
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblTransaction>> PostTblTransaction(TblTransaction tblTransaction)
        {
            _context.TblTransactions.Add(tblTransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblTransaction", new { id = tblTransaction.TranId }, tblTransaction);
        }

        // DELETE: api/TblTransaction/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblTransaction(int id)
        {
            var tblTransaction = await _context.TblTransactions.FindAsync(id);
            if (tblTransaction == null)
            {
                return NotFound();
            }

            _context.TblTransactions.Remove(tblTransaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblTransactionExists(int id)
        {
            return _context.TblTransactions.Any(e => e.TranId == id);
        }
    }
}
