using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternshipAssignment.Data;
using InternshipAssignment.Models;

namespace InternshipAssignment.Controllers
{
    public class GenderModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenderModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GenderModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.GenderModel.ToListAsync());
        }

        // GET: GenderModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genderModel = await _context.GenderModel
                .SingleOrDefaultAsync(m => m.GenderId == id);
            if (genderModel == null)
            {
                return NotFound();
            }

            return View(genderModel);
        }

        // GET: GenderModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenderModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenderId,GenderName,EntryDate")] GenderModel genderModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genderModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genderModel);
        }

        // GET: GenderModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genderModel = await _context.GenderModel.SingleOrDefaultAsync(m => m.GenderId == id);
            if (genderModel == null)
            {
                return NotFound();
            }
            return View(genderModel);
        }

        // POST: GenderModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenderId,GenderName,EntryDate")] GenderModel genderModel)
        {
            if (id != genderModel.GenderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genderModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenderModelExists(genderModel.GenderId))
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
            return View(genderModel);
        }

        // GET: GenderModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genderModel = await _context.GenderModel
                .SingleOrDefaultAsync(m => m.GenderId == id);
            if (genderModel == null)
            {
                return NotFound();
            }

            return View(genderModel);
        }

        // POST: GenderModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genderModel = await _context.GenderModel.SingleOrDefaultAsync(m => m.GenderId == id);
            _context.GenderModel.Remove(genderModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenderModelExists(int id)
        {
            return _context.GenderModel.Any(e => e.GenderId == id);
        }
    }
}
