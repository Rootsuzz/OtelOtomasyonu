using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtelOtomasyonu.Data;
using OtelOtomasyonu.Models;

namespace OtelOtomasyonu.Controllers
{
    public class OdalarsController : Controller
    {
        private readonly MyContext _context;

        public OdalarsController(MyContext context)
        {
            _context = context;
        }

        // GET: Odalars
        public async Task<IActionResult> Index()
        {
              return _context.Odalars != null ? 
                          View(await _context.Odalars.ToListAsync()) :
                          Problem("Entity set 'MyContext.Odalars'  is null.");
        }

        // GET: Odalars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Odalars == null)
            {
                return NotFound();
            }

            var odalar = await _context.Odalars
                .FirstOrDefaultAsync(m => m.OdaId == id);
            if (odalar == null)
            {
                return NotFound();
            }

            return View(odalar);
        }

        // GET: Odalars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Odalars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OdaId,OdaKat,OdaNumarasi,KisiSayisi,KiralanmaDurumu")] Odalar odalar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odalar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(odalar);
        }

        // GET: Odalars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Odalars == null)
            {
                return NotFound();
            }

            var odalar = await _context.Odalars.FindAsync(id);
            if (odalar == null)
            {
                return NotFound();
            }
            return View(odalar);
        }

        // POST: Odalars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OdaId,OdaKat,OdaNumarasi,KisiSayisi,KiralanmaDurumu")] Odalar odalar)
        {
            if (id != odalar.OdaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odalar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OdalarExists(odalar.OdaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(odalar);
        }

        // GET: Odalars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Odalars == null)
            {
                return NotFound();
            }

            var odalar = await _context.Odalars
                .FirstOrDefaultAsync(m => m.OdaId == id);
            if (odalar == null)
            {
                return NotFound();
            }

            return View(odalar);
        }

        // POST: Odalars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Odalars == null)
            {
                return Problem("Entity set 'MyContext.Odalars'  is null.");
            }
            var odalar = await _context.Odalars.FindAsync(id);
            if (odalar != null)
            {
                _context.Odalars.Remove(odalar);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OdalarExists(int id)
        {
          return (_context.Odalars?.Any(e => e.OdaId == id)).GetValueOrDefault();
        }
    }
}
