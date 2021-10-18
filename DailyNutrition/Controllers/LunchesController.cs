using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DailyNutrition.Data;
using DailyNutrition.Models;

namespace DailyNutrition.Controllers
{
    public class LunchesController : Controller
    {
        private readonly DailyNutritionContext _context;

        public LunchesController(DailyNutritionContext context)
        {
            _context = context;
        }

        // GET: Lunches
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lunch.ToListAsync());
        }

        // GET: Lunches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lunch = await _context.Lunch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lunch == null)
            {
                return NotFound();
            }

            return View(lunch);
        }

        // GET: Lunches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lunches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Date,Portion,Beverage,Volym")] Lunch lunch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lunch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lunch);
        }

        // GET: Lunches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lunch = await _context.Lunch.FindAsync(id);
            if (lunch == null)
            {
                return NotFound();
            }
            return View(lunch);
        }

        // POST: Lunches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Date,Portion,Beverage,Volym")] Lunch lunch)
        {
            if (id != lunch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lunch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LunchExists(lunch.Id))
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
            return View(lunch);
        }

        // GET: Lunches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lunch = await _context.Lunch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lunch == null)
            {
                return NotFound();
            }

            return View(lunch);
        }

        // POST: Lunches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lunch = await _context.Lunch.FindAsync(id);
            _context.Lunch.Remove(lunch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LunchExists(int id)
        {
            return _context.Lunch.Any(e => e.Id == id);
        }
    }
}
