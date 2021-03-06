using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Data;
using TimeTracker.Models;

namespace TimeTracker.Controllers
{
    public class ProjectPriorityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectPriorityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectPriority
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectPriority.ToListAsync());
        }

        // GET: ProjectPriority/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPriority = await _context.ProjectPriority
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectPriority == null)
            {
                return NotFound();
            }

            return View(projectPriority);
        }

        // GET: ProjectPriority/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectPriority/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectPriorityName")] ProjectPriority projectPriority)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectPriority);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectPriority);
        }

        // GET: ProjectPriority/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPriority = await _context.ProjectPriority.FindAsync(id);
            if (projectPriority == null)
            {
                return NotFound();
            }
            return View(projectPriority);
        }

        // POST: ProjectPriority/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectPriorityName")] ProjectPriority projectPriority)
        {
            if (id != projectPriority.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectPriority);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPriorityExists(projectPriority.Id))
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
            return View(projectPriority);
        }

        // GET: ProjectPriority/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPriority = await _context.ProjectPriority
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectPriority == null)
            {
                return NotFound();
            }

            return View(projectPriority);
        }

        // POST: ProjectPriority/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPriority = await _context.ProjectPriority.FindAsync(id);
            _context.ProjectPriority.Remove(projectPriority);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectPriorityExists(int id)
        {
            return _context.ProjectPriority.Any(e => e.Id == id);
        }
    }
}
