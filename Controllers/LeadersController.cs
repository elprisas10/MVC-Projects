using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using firstApplication.Models;
using Microsoft.AspNetCore.Authorization;

namespace firstApplication.Controllers
{
    [Authorize]
    public class LeadersController : Controller
    {
        private readonly ProjectContext _context;

        public LeadersController(ProjectContext context)
        {
            _context = context;
        }

        // GET: Leaders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Leaders.ToListAsync());
        }

        // GET: Leaders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaders = await _context.Leaders
                .FirstOrDefaultAsync(m => m.LeadersID == id);
            if (leaders == null)
            {
                return NotFound();
            }

            return View(leaders);
        }

        // GET: Leaders/Create
        public IActionResult Create()
        {
          
            return View();
        }

        // POST: Leaders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LeadersID,Name,Lastname,Email,Gender,Address")] Leaders leaders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leaders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaders);
        }

        // GET: Leaders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaders = await _context.Leaders.FindAsync(id);
            if (leaders == null)
            {
                return NotFound();
            }
            return View(leaders);
        }

        // POST: Leaders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LeadersID,Name,Lastname,Email,Gender,Address")] Leaders leaders)
        {
            if (id != leaders.LeadersID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeadersExists(leaders.LeadersID))
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
            return View(leaders);
        }

        // GET: Leaders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaders = await _context.Leaders
                .FirstOrDefaultAsync(m => m.LeadersID == id);
            if (leaders == null)
            {
                return NotFound();
            }

            return View(leaders);
        }

        // POST: Leaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaders = await _context.Leaders.FindAsync(id);
            _context.Leaders.Remove(leaders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeadersExists(int id)
        {
            return _context.Leaders.Any(e => e.LeadersID == id);
        }
    }
}
