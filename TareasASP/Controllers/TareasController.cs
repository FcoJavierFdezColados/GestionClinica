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
    public class TareasController : Controller
    {
        private readonly TareasASPContext _context;

        public TareasController(TareasASPContext context)
        {
            _context = context;
        }

        // GET: Tareas
        public async Task<IActionResult> Index(int? id, string ordenFecha, string filtroNombre)
        {
            if(id == null)
            {
                return NotFound();
            }

            if ( ordenFecha == null)
            {
                ordenFecha = "desc";
            }

            if (filtroNombre == null)
            {
                filtroNombre = "";
            }

            var tareasASPContext = await _context.ListaTareas.FirstOrDefaultAsync(t => t.Id == id);


            if (tareasASPContext != null)
            {
                ViewData["NombreListaTareas"] = tareasASPContext?.Name;
                ViewData["idListaTareas"] = tareasASPContext?.Id;
            }

            var datos = await _context
                .Tarea
                .Where(model => model.ListaTareasId == id)
                .ToListAsync();

            if(ordenFecha == "asc")
            {
                datos = datos.OrderBy(t => t.CreateDate).ToList();
            }
            else
            {
                datos = datos.OrderByDescending(t => t.CreateDate).ToList();
            }

            if(filtroNombre != "")
            {
                datos = datos.Where(t => t.Name.ToLower().Contains(filtroNombre.ToLower())).ToList();
            }

            ViewData["filtroNombre"] = filtroNombre;

            ViewData["ordenFecha"] = ordenFecha;

            return View(datos);
        }

        // GET: Tareas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarea = await _context.Tarea
                .Include(t => t.ListaTareas)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarea == null)
            {
                return NotFound();
            }

            if(tarea != null)
            {
                ViewData["NombreTarea"] = tarea.Name;
            }

            return View(tarea);
        }

        // GET: Tareas/Create
        public IActionResult Create(int listaId)
        {
            ViewData["ListaTareasId"] = new SelectList(_context.ListaTareas, "Id", "Name", listaId);
            ViewData["ListaId"] = listaId;
            return View();
        }

        // POST: Tareas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,CreateDate,ListaTareasId")] Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tarea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = tarea.ListaTareasId });
            }
            ViewData["ListaTareasId"] = new SelectList(_context.ListaTareas, "Id", "Name", tarea.ListaTareasId);
            return View(tarea);


        }

        // GET: Tareas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarea = await _context.Tarea.FindAsync(id);
            if (tarea == null)
            {
                return NotFound();
            }
            ViewData["ListaTareasId"] = new SelectList(_context.ListaTareas, "Id", "Name", tarea.ListaTareasId);
            ViewData["NombreTarea"] = tarea.Name;
            return View(tarea);
        }

        // POST: Tareas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CreateDate,ListaTareasId")] Tarea tarea)
        {
            if (id != tarea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tarea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TareaExists(tarea.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = tarea.ListaTareasId });
            }
            ViewData["ListaTareasId"] = new SelectList(_context.ListaTareas, "Id", "Name", tarea.ListaTareasId);
            return View(tarea);
        }

        // POST: Tareas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarea = await _context.Tarea.FindAsync(id);
            if (tarea != null)
            {
                _context.Tarea.Remove(tarea);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = tarea?.ListaTareasId }); ;
        }

        private bool TareaExists(int id)
        {
            return _context.Tarea.Any(e => e.Id == id);
        }
    }
}
