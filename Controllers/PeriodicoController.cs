using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using firstApplication.Models;

namespace firstApplication.Controllers
{
    public class PeriodicoController : Controller
    {
        private readonly ProjectContext _context;

        public PeriodicoController(ProjectContext context)
        {
            _context = context;
        }

        // GET: Periodico
        public async Task<IActionResult> Index()
        {
            return View(await _context.Periodico.ToListAsync());
        }

        // GET: Periodico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodico = await _context.Periodico
                .FirstOrDefaultAsync(m => m.PeriodicoID == id);
            if (periodico == null)
            {
                return NotFound();
            }

            return View(periodico);
        }

        // GET: Periodico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Periodico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PeriodicoID,description,date,name,escritor")] Periodico periodico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(periodico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(periodico);
        }

        // GET: Periodico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodico = await _context.Periodico.FindAsync(id);
            if (periodico == null)
            {
                return NotFound();
            }
            return View(periodico);
        }

        // POST: Periodico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PeriodicoID,description,date,name,escritor")] Periodico periodico)
        {
            if (id != periodico.PeriodicoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(periodico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeriodicoExists(periodico.PeriodicoID))
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
            return View(periodico);
        }

        // GET: Periodico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodico = await _context.Periodico
                .FirstOrDefaultAsync(m => m.PeriodicoID == id);
            if (periodico == null)
            {
                return NotFound();
            }

            return View(periodico);
        }

        // POST: Periodico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var periodico = await _context.Periodico.FindAsync(id);
            _context.Periodico.Remove(periodico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeriodicoExists(int id)
        {
            return _context.Periodico.Any(e => e.PeriodicoID == id);
        }
    }
}
