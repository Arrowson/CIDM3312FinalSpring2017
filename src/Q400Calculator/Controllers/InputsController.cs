using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Data;
using Q400Calculator.Models;

namespace Q400Calculator.Controllers
{
    public class InputsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InputsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Inputs1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inputs.ToListAsync());
        }

        // GET: Inputs1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (inputs == null)
            {
                return NotFound();
            }

            return View(inputs);
        }

        // GET: Inputs1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inputs1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Altitude,Icing,Name,Precipitation,RunwayDirection,TakeoffTrueFalse,Temperature,TripDistance,Weight,WindDegrees,WindSpeed")] Inputs inputs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inputs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(inputs);
        }

        // GET: Inputs1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (inputs == null)
            {
                return NotFound();
            }
            return View(inputs);
        }

        // POST: Inputs1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Altitude,Icing,Name,Precipitation,RunwayDirection,TakeoffTrueFalse,Temperature,TripDistance,Weight,WindDegrees,WindSpeed")] Inputs inputs)
        {
            if (id != inputs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inputs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InputsExists(inputs.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(inputs);
        }

        // GET: Inputs1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (inputs == null)
            {
                return NotFound();
            }

            return View(inputs);
        }

        // POST: Inputs1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            _context.Inputs.Remove(inputs);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Outputs(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (inputs == null)
            {
                return NotFound();
            }

            return View(inputs);
        }

        private bool InputsExists(int id)
        {
            return _context.Inputs.Any(e => e.ID == id);
        }
    }
}
