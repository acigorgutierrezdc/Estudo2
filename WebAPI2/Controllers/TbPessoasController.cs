using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI2.DBContext;
using WebAPI2.Entities;

namespace WebAPI2.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]

    public class TbPessoasController : ControllerBase
    {
        private readonly EstudoDBContext _context;

        public TbPessoasController(EstudoDBContext context)
        {
            _context = context;
        }

        // GET: api/TbPessoas
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbPessoa>>> GetTbPessoas()
        {
            return await _context.TbPessoas.ToListAsync();
        }

        // GET: api/TbPessoas/5
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<TbPessoa>> GetTbPessoa(Guid id)
        {
            var tbPessoa = await _context.TbPessoas.FindAsync(id);

            if (tbPessoa == null)
            {
                return NotFound();
            }

            return tbPessoa;
        }

        // PUT: api/TbPessoas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> PutTbPessoa(Guid id, TbPessoa tbPessoa)
        {
            if (id != tbPessoa.Id)
            {
                return BadRequest();
            }

            _context.Entry(tbPessoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbPessoaExists(id))
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

        // POST: api/TbPessoas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbPessoa>> PostTbPessoa(TbPessoa tbPessoa)
        {
            _context.TbPessoas.Add(tbPessoa);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbPessoaExists(tbPessoa.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbPessoa", new { id = tbPessoa.Id }, tbPessoa);
        }

        // DELETE: api/TbPessoas/5
        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteTbPessoa(Guid id)
        {
            var tbPessoa = await _context.TbPessoas.FindAsync(id);
            if (tbPessoa == null)
            {
                return NotFound();
            }

            _context.TbPessoas.Remove(tbPessoa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbPessoaExists(Guid id)
        {
            return _context.TbPessoas.Any(e => e.Id == id);
        }
    }
}
