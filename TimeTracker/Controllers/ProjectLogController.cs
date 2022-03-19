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
    public class ProjectLogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectLogController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectLog
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectLog.ToListAsync());
        }

        // GET: ProjectLog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectLog = await _context.ProjectLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectLog == null)
            {
                return NotFound();
            }

            return View(projectLog);
        }

        // GET: ProjectLog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectLog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyId,UserId,StartTime,EndTime")] ProjectLog projectLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectLog);
        }

        // GET: ProjectLog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectLog = await _context.ProjectLog.FindAsync(id);
            if (projectLog == null)
            {
                return NotFound();
            }
            return View(projectLog);
        }

        // POST: ProjectLog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyId,UserId,StartTime,EndTime")] ProjectLog projectLog)
        {
            if (id != projectLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectLogExists(projectLog.Id))
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
            return View(projectLog);
        }

        // GET: ProjectLog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectLog = await _context.ProjectLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectLog == null)
            {
                return NotFound();
            }

            return View(projectLog);
        }

        // POST: ProjectLog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectLog = await _context.ProjectLog.FindAsync(id);
            _context.ProjectLog.Remove(projectLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectLogExists(int id)
        {
            return _context.ProjectLog.Any(e => e.Id == id);
        }
    }
}
