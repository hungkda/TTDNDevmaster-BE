using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab09.Models;

namespace Lab09.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class ExtensionsController : Controller
    {
        private readonly DevXuongMocContext _context;

        public ExtensionsController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: Admins/Extensions
        public async Task<IActionResult> Index()
        {
              return _context.Extensions != null ? 
                          View(await _context.Extensions.ToListAsync()) :
                          Problem("Entity set 'DevXuongMocContext.Extensions'  is null.");
        }

        // GET: Admins/Extensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Extensions == null)
            {
                return NotFound();
            }

            var extension = await _context.Extensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extension == null)
            {
                return NotFound();
            }

            return View(extension);
        }

        // GET: Admins/Extensions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Extensions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Icon,MetaTitle,MetaKeyword,MetaDescription,Slug,Orders,Parentid,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Notes,Status,Isdelete")] Extension extension)
        {
            if (ModelState.IsValid)
            {
                _context.Add(extension);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(extension);
        }

        // GET: Admins/Extensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Extensions == null)
            {
                return NotFound();
            }

            var extension = await _context.Extensions.FindAsync(id);
            if (extension == null)
            {
                return NotFound();
            }
            return View(extension);
        }

        // POST: Admins/Extensions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Icon,MetaTitle,MetaKeyword,MetaDescription,Slug,Orders,Parentid,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Notes,Status,Isdelete")] Extension extension)
        {
            if (id != extension.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(extension);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtensionExists(extension.Id))
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
            return View(extension);
        }

        // GET: Admins/Extensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Extensions == null)
            {
                return NotFound();
            }

            var extension = await _context.Extensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extension == null)
            {
                return NotFound();
            }

            return View(extension);
        }

        // POST: Admins/Extensions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Extensions == null)
            {
                return Problem("Entity set 'DevXuongMocContext.Extensions'  is null.");
            }
            var extension = await _context.Extensions.FindAsync(id);
            if (extension != null)
            {
                _context.Extensions.Remove(extension);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExtensionExists(int id)
        {
          return (_context.Extensions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
