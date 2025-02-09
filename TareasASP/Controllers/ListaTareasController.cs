using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TareasASP.Data;
using TareasASP.Models;

namespace TareasASP.Controllers
{
    public class ListaTareasController : Controller
    {
        private readonly TareasASPContext _context;

        public ListaTareasController(TareasASPContext context)
        {
            _context = context;
        }

        // GET: ListaTareas
        public async Task<IActionResult> Index()
        {          
            var listaTareas = await _context.ListaTareas
                .Include(x => x.Tareas)
                .ToListAsync();

            //return View(await _context.ListaTareas.ToListAsync());
            return View(listaTareas);
        }

        //// GET: ListaTareas/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var listaTareas = await _context.ListaTareas
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (listaTareas == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(listaTareas);
        //}

        // GET: ListaTareas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ListaTareas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ListaTareas listaTareas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listaTareas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listaTareas);
        }

        // GET: ListaTareas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaTareas = await _context.ListaTareas.FindAsync(id);
            if (listaTareas == null)
            {
                return NotFound();
            }
            ViewData["NombreListaTareas"] = listaTareas.Name;
            return View(listaTareas);
        }

        // POST: ListaTareas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ListaTareas listaTareas)
        {
            if (id != listaTareas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaTareas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListaTareasExists(listaTareas.Id))
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
            return View(listaTareas);
        }

        //// GET: ListaTareas/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var listaTareas = await _context.ListaTareas
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (listaTareas == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(listaTareas);
        //}

        // POST: ListaTareas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {   
            if(id == null)
            {
                return NotFound();
            }
            
            var listaTareas = await _context.ListaTareas
                .Include(t => t.Tareas)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (listaTareas != null)            {
                
                _context.ListaTareas.Remove(listaTareas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(listaTareas);
        }

        private bool ListaTareasExists(int id)
        {
            return _context.ListaTareas.Any(e => e.Id == id);
        }
    }
}
