﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineSalePrj.Data;
using OnlineSalePrj.Models;

namespace OnlineSalePrj.Controllers
{
    public class TownsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TownsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Towns
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Towns.Include(t => t.Region);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Towns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Towns
                .Include(t => t.Region)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (town == null)
            {
                return NotFound();
            }

            return View(town);
        }

        // GET: Towns/Create
        public IActionResult Create()
        {
            ViewData["RegionId"] = new SelectList(_context.Regions, "ID", "Name");
            return View();
        }

        // POST: Towns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,RegionId")] Town town)
        {
            if (ModelState.IsValid)
            {
                _context.Add(town);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RegionId"] = new SelectList(_context.Regions, "ID", "Name", town.RegionId);
            return View(town);
        }

        // GET: Towns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Towns.FindAsync(id);
            if (town == null)
            {
                return NotFound();
            }
            ViewData["RegionId"] = new SelectList(_context.Regions, "ID", "Name", town.RegionId);
            return View(town);
        }

        // POST: Towns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,RegionId")] Town town)
        {
            if (id != town.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(town);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TownExists(town.ID))
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
            ViewData["RegionId"] = new SelectList(_context.Regions, "ID", "Name", town.RegionId);
            return View(town);
        }

        // GET: Towns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var town = await _context.Towns
                .Include(t => t.Region)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (town == null)
            {
                return NotFound();
            }

            return View(town);
        }

        // POST: Towns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var town = await _context.Towns.FindAsync(id);
            _context.Towns.Remove(town);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TownExists(int id)
        {
            return _context.Towns.Any(e => e.ID == id);
        }
    }
}
