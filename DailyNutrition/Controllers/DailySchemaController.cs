using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DailyNutrition.DataContext;
using DailyNutrition.Models;

namespace DailyNutrition.Controllers
{
    public class DailySchemaController : Controller
    {
        private readonly DailyNutritionContext _context;

        public DailySchemaController(DailyNutritionContext context)
        {
            _context = context;
        }

        // GET: DailySchema
        public async Task<IActionResult> Index()
        {
            return View(await _context.Schemas.ToListAsync());
        }

        // GET: DailySchema/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schema = await _context.Schemas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (schema == null)
            {
                return NotFound();
            }

            return View(schema);
        }

        // GET: DailySchema/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DailySchema/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Date,FeedingDuration,Description,FormulaAmount,D_Vitamin_Intake")] Schema schema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schema);
        }

        // GET: DailySchema/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schema = await _context.Schemas.FindAsync(id);
            if (schema == null)
            {
                return NotFound();
            }
            return View(schema);
        }

        // POST: DailySchema/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,FeedingDuration,Description,FormulaAmount,D_Vitamin_Intake")] Schema schema)
        {
            if (id != schema.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchemaExists(schema.ID))
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
            return View(schema);
        }

        // GET: DailySchema/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schema = await _context.Schemas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (schema == null)
            {
                return NotFound();
            }

            return View(schema);
        }

        // POST: DailySchema/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schema = await _context.Schemas.FindAsync(id);
            _context.Schemas.Remove(schema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchemaExists(int id)
        {
            return _context.Schemas.Any(e => e.ID == id);
        }
    }
}
