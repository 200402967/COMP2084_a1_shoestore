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
    public class FootwearController : Controller
    {
        private readonly ShoeStoreContext _context;

        public FootwearController(ShoeStoreContext context)
        {
            _context = context;
        }

        // GET: Footwear
        public async Task<IActionResult> Index()
        {
            return View(await _context.Genre.ToListAsync());
        }

        // GET: Footwear/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = await _context.Genre
                .FirstOrDefaultAsync(m => m.GenreId == id);
            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // GET: Footwear/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FootwearId,Name")] Footwear footwear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footwear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footwear);
        }

        // GET: Footwear/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = await _context.Genre.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        // POST: Footwear/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FootwearId,Name")] Footwear footwear)
        {
            if (id != footwear.FootwearId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footwear);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenreExists(footwear.FootwearId))
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
            return View(footwear);
        }

        // GET: Footwear/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footwear = await _context.Footwear
                .FirstOrDefaultAsync(m => m.FootwearId == id);
            if (footwear == null)
            {
                return NotFound();
            }

            return View(footwear);
        }

        // POST: Footwear/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var footwear = await _context.Footwear.FindAsync(id);
            _context.Genre.Remove(footwear);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FootwearExists(int id)
        {
            return _context.Footwear.Any(e => e.FootwearId == id);
        }
    }
}
