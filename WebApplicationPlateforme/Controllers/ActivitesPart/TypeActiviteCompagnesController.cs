﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationPlateforme.Data;
using WebApplicationPlateforme.Model.ActivitePart;

namespace WebApplicationPlateforme.Controllers.ActivitesPart
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeActiviteCompagnesController : ControllerBase
    {
        private readonly DawaaContext _context;

        public TypeActiviteCompagnesController(DawaaContext context)
        {
            _context = context;
        }

        // GET: api/TypeActiviteCompagnes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeActiviteCompagne>>> GetTypeActiviteCompagnes()
        {
            return await _context.TypeActiviteCompagnes.ToListAsync();
        }

        // GET: api/TypeActiviteCompagnes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeActiviteCompagne>> GetTypeActiviteCompagne(int id)
        {
            var typeActiviteCompagne = await _context.TypeActiviteCompagnes.FindAsync(id);

            if (typeActiviteCompagne == null)
            {
                return NotFound();
            }

            return typeActiviteCompagne;
        }

        // PUT: api/TypeActiviteCompagnes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeActiviteCompagne(int id, TypeActiviteCompagne typeActiviteCompagne)
        {
            if (id != typeActiviteCompagne.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeActiviteCompagne).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeActiviteCompagneExists(id))
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

        // POST: api/TypeActiviteCompagnes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TypeActiviteCompagne>> PostTypeActiviteCompagne(TypeActiviteCompagne typeActiviteCompagne)
        {
            _context.TypeActiviteCompagnes.Add(typeActiviteCompagne);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeActiviteCompagne", new { id = typeActiviteCompagne.Id }, typeActiviteCompagne);
        }

        // DELETE: api/TypeActiviteCompagnes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TypeActiviteCompagne>> DeleteTypeActiviteCompagne(int id)
        {
            var typeActiviteCompagne = await _context.TypeActiviteCompagnes.FindAsync(id);
            if (typeActiviteCompagne == null)
            {
                return NotFound();
            }

            _context.TypeActiviteCompagnes.Remove(typeActiviteCompagne);
            await _context.SaveChangesAsync();

            return typeActiviteCompagne;
        }

        private bool TypeActiviteCompagneExists(int id)
        {
            return _context.TypeActiviteCompagnes.Any(e => e.Id == id);
        }
    }
}
