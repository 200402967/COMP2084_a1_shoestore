using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP2084_a1_shoestore.Models;

namespace COMP2084_a1_shoestore.Controllers
{
    public class ShoeTypeController : Controller
    {
        private readonly ShoeStoreContext _context;

        public ShoeTypeController(ShoeStoreContext context)
        {
            _context = context;
        }

        // GET: ShoeType
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShoeType.ToListAsync());
        }

        // GET: ShoeType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ShoeType = await _context.ShoeType
                .FirstOrDefaultAsync(m => m.ShoeTypeId == id);
            if (ShoeType == null)
            {
                return NotFound();
            }

            return View(ShoeType);
        }

        // GET: ShoeType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoeType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShoeId,ShoeTypeId,ShoeName,Brand,Color,Size")] ShoeType ShoeType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ShoeType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ShoeType);
        }

        // GET: ShoeType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ShoeType = await _context.ShoeType.FindAsync(id);
            if (ShoeType == null)
            {
                return NotFound();
            }
            return View(ShoeType);
        }

        // POST: ShoeType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShoeId,ShoeTypeId,ShoeName,Brand,Color,Size")] ShoeType ShoeType)
        {
            if (id != ShoeType.ShoeTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ShoeType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoeTypeExists(ShoeType.ShoeTypeId))
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
            return View(ShoeType);
        }

        // GET: ShoeType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ShoeType = await _context.ShoeType
                .FirstOrDefaultAsync(m => m.ShoeTypeId == id);
            if (ShoeType == null)
            {
                return NotFound();
            }

            return View(ShoeType);
        }

        // POST: ShoeType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ShoeType = await _context.ShoeType.FindAsync(id);
            _context.ShoeType.Remove(ShoeType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoeTypeExists(int id)
        {
            return _context.ShoeType.Any(e => e.ShoeTypeId == id);
        }
    }
}
